using System;
using System.Collections.Generic;
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

namespace Gayfullin
{
    /// <summary>
    /// Логика взаимодействия для ServicePage.xaml
    /// </summary>
    public partial class AgentPage : Page
    {
        public AgentPage()
        {
            InitializeComponent();

            var currentAgents = GlazkiSaveGayfullinEntities.GetContext().Agent.ToList();

            AgentListView.ItemsSource = currentAgents;

            ComboFiltration.SelectedIndex = ComboSort.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage());
        }

        private void ComboSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var currentAgents = GlazkiSaveGayfullinEntities.GetContext().Agent.ToList();
            switch(ComboSort.SelectedIndex)
            {
                case 0:
                    AgentListView.ItemsSource = currentAgents;
                    break;
                case 1:
                    AgentListView.ItemsSource = currentAgents.OrderBy(p => p.Title);
                    break;
                case 2:
                    AgentListView.ItemsSource = currentAgents.OrderBy(p => p.Discount);
                    break;
                case 3:
                    AgentListView.ItemsSource = currentAgents.OrderBy(p => p.Priority);
                    break;
            }
        }

        private void ComboFiltration_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var currentAgents = GlazkiSaveGayfullinEntities.GetContext().Agent.ToList();
            switch (ComboFiltration.SelectedIndex)
            {
                case 0:
                    AgentListView.ItemsSource = currentAgents;
                    break;
                case 1:
                    AgentListView.ItemsSource = currentAgents.Where(p => p.AgentTypeText == "МФО");
                    break;
                case 2:
                    AgentListView.ItemsSource = currentAgents.Where(p => p.AgentTypeText == "ООО");
                    break;
                case 3:
                    AgentListView.ItemsSource = currentAgents.Where(p => p.AgentTypeText == "ЗАО");
                    break;
                case 4:
                    AgentListView.ItemsSource = currentAgents.Where(p => p.AgentTypeText == "МКК");
                    break;
                case 5:
                    AgentListView.ItemsSource = currentAgents.Where(p => p.AgentTypeText == "ОАО");
                    break;
                case 6:
                    AgentListView.ItemsSource = currentAgents.Where(p => p.AgentTypeText == "ПАО");
                    break;
            }
        }

        private void SearchTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            var currentAgents = GlazkiSaveGayfullinEntities.GetContext().Agent.ToList();
            AgentListView.ItemsSource = currentAgents.Where(p => p.Title.ToLower().Contains(SearchTB.Text.ToLower()));
        }
    }
}
