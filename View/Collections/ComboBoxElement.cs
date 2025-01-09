using OCESACNA.Engine.Collections;

namespace OCESACNA.View.Collections
{
    public class ComboBoxElement
    {
        public string Text { get; set; }
        public object Value { get; set; }
    }

    public class RankComboBoxElement : ComboBoxElement
    {
        public new User.RANKING Value { get; set; }

        public RankComboBoxElement(string Text, User.RANKING Value)
        {
            this.Text = Text;
            this.Value = Value;
        }
    }

    public class StateComboBoxElement : ComboBoxElement
    {
        public new User.STATES Value { get; set; }

        public StateComboBoxElement(string Text, User.STATES Value)
        {
            this.Text = Text;
            this.Value = Value;
        }
    }
}
