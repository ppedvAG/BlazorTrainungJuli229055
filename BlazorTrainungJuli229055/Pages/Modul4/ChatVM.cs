namespace BlazorTrainungJuli229055.Pages.Modul4
{
    public class ChatVM
    {
        public List<NachrichtModel> ChatListe { get; set; }=new List<NachrichtModel>();
        public Action OnAdd;
        public void Add(string Nachricht)
        {
            ChatListe.Add(new NachrichtModel { Text = Nachricht });
            OnAdd?.Invoke();

        }

    }
}
