using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace WpfApp1
{
    class DropBehavior : Behavior<FrameworkElement>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            this.AssociatedObject.Drop += OnDrop;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            this.AssociatedObject.Drop -= OnDrop;
        }

        private void OnDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(typeof(ChoiceExpression)) as ChoiceExpression;

            var element = e.OriginalSource as FrameworkElement;
            if (element is null) return;

            var cell = element.Parent as DataGridCell;
            if (cell is null) return;

            var cellContext = cell.DataContext as TableData;

            var dataGrid = sender as DataGrid;
            var vm = dataGrid.DataContext as MainWindowVM;

            List<TableData> list = vm.TableDatas;

            var rowData = list.Find(d => d.Number == cellContext.Number);

            rowData.Value = data.Value;
        }
    }
}
