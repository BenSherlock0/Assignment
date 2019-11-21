﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Activity> activities = new ObservableCollection<Activity>();
        ObservableCollection<Activity> selectedactivities = new ObservableCollection<Activity>();
        public MainWindow()
        {
            InitializeComponent();
            lbxAll.ItemsSource = activities;
            lbxSelected.ItemsSource = selectedactivities;


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Activity l1 = new Activity("Treking", "Instructor led group trek through local mountains.", new DateTime(2019, 06, 01), ActivityType.Land, 20m);

            Activity l2 = new Activity()
            {
                Name = "Mountain Biking",
                Description = "Instructor led half day mountain biking.  All equipment provided.",
                ActivityDate = new DateTime(2019, 06, 02),
                TypeOfActivity = ActivityType.Land,
                Cost = 30m
            };

            Activity l3 = new Activity()
            {
                Name = "Abseiling",
                Description = "Experience the rush of adrenaline as you descend cliff faces from 10-500m.",
                ActivityDate = new DateTime(2019, 06, 03),
                TypeOfActivity = ActivityType.Land,
                Cost = 40m
            };

            Activity w1 = new Activity()
            {
                Name = "Kayaking",
                Description = "Half day lakeland kayak with island picnic.",
                ActivityDate = new DateTime(2019, 06, 01),
                TypeOfActivity = ActivityType.Water,
                Cost = 40m
            };

            Activity w2 = new Activity()
            {
                Name = "Surfing",
                Description = "2 hour surf lesson on the wild atlantic way",
                ActivityDate = new DateTime(2019, 06, 02),
                TypeOfActivity = ActivityType.Water,
                Cost = 25m
            };

            Activity w3 = new Activity()
            {
                Name = "Sailing",
                Description = "Full day lakeland kayak with island picnic.",
                ActivityDate = new DateTime(2019, 06, 03),
                TypeOfActivity = ActivityType.Water,
                Cost = 50m
            };

            Activity a1 = new Activity()
            {
                Name = "Parachuting",
                Description = "Experience the thrill of free fall while you tandem jump from an airplane.",
                ActivityDate = new DateTime(2019, 06, 01),
                TypeOfActivity = ActivityType.Air,
                Cost = 100m
            };

            Activity a2 = new Activity()
            {
                Name = "Hang Gliding",
                Description = "Soar on hot air currents and enjoy spectacular views of the coastal region.",
                ActivityDate = new DateTime(2019, 06, 02),
                TypeOfActivity = ActivityType.Air,
                Cost = 80m
            };

            Activity a3 = new Activity()
            {
                Name = "Helicopter Tour",
                Description = "Experience the ultimate in aerial sight-seeing as you tour the area in our modern helicopters",
                ActivityDate = new DateTime(2019, 06, 03),
                TypeOfActivity = ActivityType.Air,
                Cost = 200m
            };

            activities.Add(l1);
            activities.Add(l2);
            activities.Add(l3);
            activities.Add(w1);
            activities.Add(w2);
            activities.Add(w3);
            activities.Add(a1);
            activities.Add(a2);
            activities.Add(a3);
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Activity selectedactivity = lbxAll.SelectedItem as Activity;

            if(selectedactivity != null)
            {
                activities.Remove(selectedactivity);
                selectedactivities.Add(selectedactivity);
            }
            else
            {
                MessageBox.Show("Nothing has been selected.\nPlease select a activity.");
            }
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            Activity selectedactivty = lbxSelected.SelectedItem as Activity;

            if(selectedactivty != null)
            {
                selectedactivities.Remove(selectedactivty);
                activities.Add(selectedactivty);
            }
            else
            {
                MessageBox.Show("Nothing has been selected.\nPlease select a activity.");
            }
        }


        private void LbxAll_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Activity selectedactivty = lbxAll.SelectedItem as Activity;

                string description = selectedactivty.Description;

                txtblkDescription.Text = description;
            }
            catch
            {

            }

        }

        private void LbxSelected_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                Activity selectedactivty = lbxSelected.SelectedItem as Activity;

                string description = selectedactivty.Description;

                txtblkDescription.Text = description;
            }
            catch
            {

            }
        }
    }
}
