using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;
using KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolOsztalyzatok
{
    public partial class SchoolOsztalyzatokViewModel : BaseViewModel
    {
        private AktualisOraViewModel _aktualisOraViewModel;
        private TanitottOsztalyokViewModel _tanitottOsztalyokViewModel;
        private FelevZarasViewModel _felevZarasViewModel;
        private EvVegeZarasViewModel _evVegeZarasViewModel;

        public SchoolOsztalyzatokViewModel()
        {
            _currentSchoolOsztalyzatokChildView = new AktualisOraViewModel();
            _aktualisOraViewModel = new AktualisOraViewModel();
            _tanitottOsztalyokViewModel = new TanitottOsztalyokViewModel();
            _felevZarasViewModel = new FelevZarasViewModel();
            _evVegeZarasViewModel = new EvVegeZarasViewModel();
        }

        public SchoolOsztalyzatokViewModel(AktualisOraViewModel aktualisOraViewModel, TanitottOsztalyokViewModel tanitottOsztalyokViewModel, FelevZarasViewModel felevZarasViewModel, EvVegeZarasViewModel evVegeZarasViewModel)
        {
            _aktualisOraViewModel = aktualisOraViewModel;
            _tanitottOsztalyokViewModel = tanitottOsztalyokViewModel;
            _felevZarasViewModel = felevZarasViewModel;
            _evVegeZarasViewModel = evVegeZarasViewModel;

            _currentSchoolOsztalyzatokChildView = new SchoolOsztalyzatokViewModel();
        }

        [ObservableProperty]
        private BaseViewModel _currentSchoolOsztalyzatokChildView;

        [RelayCommand]
        public void ShowAktualisOraView()
        {
            CurrentSchoolOsztalyzatokChildView = _aktualisOraViewModel;
        }

        [RelayCommand]
        public void ShowTanitottOsztalyokView()
        {
            CurrentSchoolOsztalyzatokChildView = _tanitottOsztalyokViewModel;
        }

        [RelayCommand]
        public void ShowFelevZarasView()
        {
            CurrentSchoolOsztalyzatokChildView = _felevZarasViewModel;
        }

        [RelayCommand]
        public void ShowEvVegeZarasView()
        {
            CurrentSchoolOsztalyzatokChildView = _evVegeZarasViewModel;
        }
    }
}
