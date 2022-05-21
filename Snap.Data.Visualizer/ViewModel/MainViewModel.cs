using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Snap.Data.Mapper.Abstraction;
using Snap.Data.Mapper.Converter;
using Snap.Data.Mapper.Model.ObjectModel;
using Snap.Data.Mapper.Model.ObjectModel.Converter;
using Snap.Data.Visualizer.TextMapping;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using System.Windows.Input;

namespace Snap.Data.Visualizer.ViewModel;
internal class MainViewModel : ObservableObject
{
    private const string TextMapFolderName = "TextMap";

    private string? genshinDataFolder;
    private IList<ITextMap>? textMaps;
    private ITextMap? selectedTextMap;
    private IList<NamedValue<Lazy<IOutputHandler>>>? outputHandlers;
    private NamedValue<Lazy<IOutputHandler>>? selectedOutputHandler;

    public MainViewModel()
    {
        SelectDataFolderCommand = new RelayCommand(SelectDataFolder);
        ExportSelectedOutputDataCommand = new RelayCommand(ExportSelectedOutputData);
    }

    public IList<ITextMap>? TextMaps
    {
        get => textMaps;
        set => SetProperty(ref textMaps, value);
    }

    public ITextMap? SelectedTextMap
    {
        get => selectedTextMap;
        set
        {
            SetProperty(ref selectedTextMap, value);
            UpdateOutputHandlers();

            JsonContext.Options = JsonContext.CreateDefaultOption();

            if (value != null)
            {
                AddJsonConverters(JsonContext.Options.Converters, value);
            }
        }
    }

    public IList<NamedValue<Lazy<IOutputHandler>>>? OutputHandlers
    {
        get => outputHandlers;
        set => SetProperty(ref outputHandlers, value);
    }

    public NamedValue<Lazy<IOutputHandler>>? SelectedOutputHandler
    {
        get => selectedOutputHandler;
        set => SetProperty(ref selectedOutputHandler, value);
    }

    public ICommand SelectDataFolderCommand { get; }
    public ICommand ExportSelectedOutputDataCommand { get; }

    private void AddJsonConverters(IList<JsonConverter> converters, ITextMap value)
    {
        converters.Add(new TextMapHashConverter(value));
        converters.Add(new HashPreConverter());
        converters.Add(new HashSuffixConverter());
    }

    private void SelectDataFolder()
    {
        using (FolderBrowserDialog openFileDlg = new())
        {
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                genshinDataFolder = openFileDlg.SelectedPath;

                string textMapFolder = Path.Combine(genshinDataFolder, TextMapFolderName);

                // text map
                SelectedTextMap = null;
                TextMaps = Directory
                    .GetFiles(textMapFolder)
                    .Select(path => new TextMap(path))
                    .Cast<ITextMap>()
                    .ToList();

                UpdateTextMaps();
                UpdateOutputHandlers();
            }
        }
    }

    private void ExportSelectedOutputData()
    {
        if(SelectedOutputHandler is null)
        {
            return;
        }

        SaveFileDialog saveFileDialog = new()
        { 
            FileName = $"{SelectedOutputHandler.Name}.json",
        };
        using (saveFileDialog)
        {
            if(saveFileDialog.ShowDialog() is DialogResult.OK)
            {
                string targetPath = saveFileDialog.FileName;
                File.WriteAllText(targetPath, SelectedOutputHandler.Value.Value.Output);
            }
        }
    }

    private void UpdateTextMaps()
    {
        if (genshinDataFolder is null)
        {
            return;
        }

        string textMapFolder = Path.Combine(genshinDataFolder, TextMapFolderName);

        // text map
        SelectedTextMap = null;
        TextMaps = Directory
            .GetFiles(textMapFolder)
            .Select(path => new TextMap(path))
            .Cast<ITextMap>()
            .ToList();
    }

    private void UpdateOutputHandlers()
    {
        if (genshinDataFolder is null)
        {
            return;
        }

        if (SelectedTextMap is null)
        {
            return;
        }

        OutputHandlers = ExcelBin.Initialize(genshinDataFolder);
    }
}
