using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    class MainWindowVM
    {
        public List<TableData> TableDatas { set; get; } = new List<TableData>
        {
            new TableData { Number = 1, Name = "Tax", Value = "n * 1.10"},
            new TableData { Number = 2, Name = "Summer campaign", Value = "n * 0.8"}
        };

        public List<ChoiceGroup> Choices { set; get; } = new List<ChoiceGroup>
        {
            new ChoiceGroup {
                Name = "Campaign", Childs = new List<ChoiceExpression>
                {
                    new ChoiceExpression { Value = "n * 0.9" },
                    new ChoiceExpression { Value = "n * 0.8" },
                    new ChoiceExpression { Value = "n * 0.7" },
                }
            }
        };
    }
}
