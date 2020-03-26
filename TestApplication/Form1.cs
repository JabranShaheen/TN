using System;
using System.Windows.Forms;
using TN.Abstractions.BLL.PuzzleBatchBuilder;
using Unity;
using System.Linq;

namespace TestApplication
{
    public partial class Form1 : Form
    {
        UnityContainer unityContainer = new UnityContainer();
        IPuzzleBatchBuilder<int> PuzzleBatchBuilder;
        IPuzzleBatchBuilderDirector puzzleBatchBuilderDirector;
        public Form1()
        {
            TN.Logic.IOC.Bootstrap.Register(unityContainer);
            PuzzleBatchBuilder = unityContainer.Resolve<IPuzzleBatchBuilder<int>>();
            puzzleBatchBuilderDirector = unityContainer.Resolve<IPuzzleBatchBuilderDirector>();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PuzzleBatchBuilder.BuildPuzzleBatch();
            puzzleBatchBuilderDirector.BuildPuzzleBatch(PuzzleBatchBuilder);

            var listOfPuzzle = PuzzleBatchBuilder.GetPuzzleBatch();

            foreach (var puzzle in listOfPuzzle)
            {                
                    this.listBox1.Items.Add(string.Join(",", puzzle.PuzzleDisplay.ToArray()) + "## Answer Options" + string.Join(",", puzzle.AnswerOptions.ToArray()) + " ## Answer" + puzzle.CorrectAnswer.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


