namespace Infernis_Quest_Constructor
{
    public partial class MainForm : Form
    {
#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
#pragma warning disable IDE0044 // Добавить модификатор только для чтения
#pragma warning disable IDE1006 // Стили именования
        public MainForm()
        {
            InitializeComponent();
        }
        // Об'явлення типів даних, які в майбутньому використовуватимуться для створення квестів
        static string infquest_str_quest_id, infquest_str_quest_icon, infquest_str_quest_title, infquest_str_quest_description, infquest_str_quest_target, infquest_str_quest_condlist_0, infquest_str_quest_condlist_1, infquest_str_quest_condlist_2, infquest_str_quest_reward_item;
        static int infquest_int_prior, infquest_int_quest_reward_money;
        static bool infquest_bool_storyline;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(questPriorTB.Text);
            }
            catch (ArgumentNullException)
            {
                priorAuto();
                try
                {
                    Clipboard.SetText(infquest_str_quest_target);
                    copyQuest();
                }
                catch (ArgumentNullException)
                {
                    targetNil();
                    copyQuest();
                }
            }
            finally
            {
                try
                {
                    Clipboard.SetText(infquest_str_quest_target);
                    copyQuest();
                }
                catch (ArgumentNullException)
                {
                    targetNil();
                    copyQuest();
                }
            }
        }
        // Швидкі присваювання параметрів
        private static void storylineFalse() => infquest_bool_storyline = false;
        private static void targetNil() => infquest_str_quest_target = "nil";
        private static void priorAuto() => infquest_int_prior = 100;
        private static void moneyAuto() => infquest_int_quest_reward_money = 0;
        private static void copyQuest()
        {
            // Об'явлення головного скелету квесту
            string infQuestSkeleton = "[" + infquest_str_quest_id + "]\nicon = ui_inGame2_" + infquest_str_quest_icon + "\nprior = " + infquest_int_prior + "\nstoryline = " + infquest_bool_storyline + "\ntitle = \u0022" + infquest_str_quest_title + "\u0022\ndescr = \u0022" + infquest_str_quest_description + "\u0022\ntarget = " + infquest_str_quest_target + "\ncondlist_0 = {" + infquest_str_quest_condlist_0 + "} complete\ncondlist_1 = {" + infquest_str_quest_condlist_1 + "} reversed\ncondlist_2 = {" + infquest_str_quest_condlist_2 + "} fail\nreward_item = " + infquest_str_quest_reward_item + "\nreward_money = " + infquest_int_quest_reward_money + "\n\n";
            Clipboard.SetText(infQuestSkeleton);
        }
        private void questIDTB_TextChanged(object sender, EventArgs e)
        {
            infquest_str_quest_id = questIDTB.Text;
        }
        private void questNameTB_TextChanged(object sender, EventArgs e)
        {
            infquest_str_quest_title = questNameTB.Text;
        }
        private void questDescriptionTB_TextChanged(object sender, EventArgs e)
        {
            infquest_str_quest_description = questDescriptionTB.Text;
        }
        private void questIconComboBox_TextChanged(object sender, EventArgs e)
        {
            infquest_str_quest_icon = questIconComboBox.Text;
        }
        private void questPriorTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                infquest_int_prior = int.Parse(questPriorTB.Text);
            }
            catch (FormatException)
            {
                priorAuto();
            }
        }
        private void isStorylineCheckedChanged(object sender, EventArgs e)
        {
            if (isStorylineTrue.Checked) infquest_bool_storyline = true;
            else if (isStorylineFalse.Checked) storylineFalse();
            else storylineFalse();
        }
        private void questTargetTB_TextChanged(object sender, EventArgs e)
        {
            bool b = questTargetTB.Text.Contains(' ');
            if (!b) infquest_str_quest_target = questTargetTB.Text;
            else targetNil();
        }

        private void condlist_0_TB_TextChanged(object sender, EventArgs e)
        {
            infquest_str_quest_condlist_0 = condlist_0_TB.Text;
        }

        private void condlist_1_TB_TextChanged(object sender, EventArgs e)
        {
            infquest_str_quest_condlist_1 = condlist_1_TB.Text;
        }

        private void condlist_2_TB_TextChanged(object sender, EventArgs e)
        {
            infquest_str_quest_condlist_2 = condlist_2_TB.Text;
        }

        private void rewardItemTB_TextChanged(object sender, EventArgs e)
        {
            infquest_str_quest_reward_item = rewardItemTB.Text;
        }

        private void rewardMoneyTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                infquest_int_quest_reward_money = int.Parse(rewardMoneyTB.Text);
            }
            catch (FormatException)
            {
                moneyAuto();
            }
        }
    }
}
// Да и хуй с ним!
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
#pragma warning restore IDE0044 // Добавить модификатор только для чтения
#pragma warning restore IDE1006 // Стили именования