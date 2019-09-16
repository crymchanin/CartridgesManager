using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace CartridgesManager.Controls {
    public partial class AlphabetBox : UserControl {

        private const int ContentMargins = 15;
        private const int ContentWidth = 207;

        private readonly char[][] alphabet = {
            new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' },
            new char[] { 'а', 'б', 'в' },
            new char[] { 'г', 'д', 'е' },
            new char[] { 'ё', 'ж', 'з' },
            new char[] { 'и', 'й', 'к' },
            new char[] { 'л', 'м', 'н' },
            new char[] { 'о' },
            new char[] { 'п', 'р' },
            new char[] { 'с', 'т', 'у' },
            new char[] { 'ф', 'х', 'ц' },
            new char[] { 'ч', 'ш', 'щ' },
            new char[] { 'э', 'ю', 'я' }
        };

        /// <summary>
        /// 
        /// </summary>
        public delegate void LoadContentPageEventHandler(AlphabetBox sender, char[] words);

        /// <summary>
        /// 
        /// </summary>
        public event LoadContentPageEventHandler LoadContentPage;


        public AlphabetBox() {
            InitializeComponent();

            LoadMainPage();
        }

        /// <summary>
        /// Загружает контент главной страницы
        /// </summary>
        public void LoadMainPage() {
            ContentLayoutPanel.Controls.Clear();

            GuiController.ControlCallback callback = delegate (string code) {
                ContentLayoutPanel.Controls.Clear();
                LinearButton sender = GuiController.GetAssociatedControl(code);
                LoadContentPage?.Invoke(this, sender.GetCustomData<char[]>());
            };

            List<LinearButton> buttons = new List<LinearButton>();
            int index = 0;
            foreach (char[] words in alphabet) {
                LinearButton button = new LinearButton();
                button.ButtonText = string.Join("", words).ToUpper();

                button.Barcode = button.RegisterControl(callback);
                button.ButtonBackColor = Color.DarkSeaGreen;
                button.Anchor = AnchorStyles.Left | AnchorStyles.Top;
                button.CompactMode = true;
                button.ButtonFontSize = 9.25F;
                button.TabIndex = index;
                button.Margin = new Padding(0, 0, ContentMargins, ContentMargins);

                button.SetCustomData(alphabet[index]);

                buttons.Add(button);
                index++;
            }
            ContentLayoutPanel.Controls.AddRange(buttons.ToArray());
        }

        /// <summary>
        /// Возвращает коллекцию элементов управления, содержащихся в элементе управления
        /// </summary>
        public ControlCollection ContentControls {
            get {
                return ContentLayoutPanel.Controls;
            }
        }
    }
}
