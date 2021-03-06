using Esri.ArcGISRuntime.Mapping;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;


namespace agr_test_executable
{

    /// <summary>
    /// Provides map data to an application
    /// </summary>
    public class MapViewModel : INotifyPropertyChanged
    {




        public MapViewModel()
        {



        }

        private Map _map = new Map(Basemap.CreateLightGrayCanvasVector());

        /// <summary>
        /// Gets or sets the map
        /// </summary>
        public Map Map
        {
            get => _map;
            set { _map = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// Raises the <see cref="MapViewModel.PropertyChanged" /> event
        /// </summary>
        /// <param name="propertyName">The name of the property that has changed</param>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));



        public event PropertyChangedEventHandler PropertyChanged;



    }
}
