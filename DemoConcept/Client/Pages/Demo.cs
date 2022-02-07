using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace DemoConcept.Client.Pages
{
    public partial class Demo
    {
        [Inject]
        private IJSRuntime _js { get; set; }
        public int Valeur { get; set; } = 5;

        public List<int> Valeurs { get; set; }


        public Demo()
        {
            
            Valeurs = new List<int>();
        }
        //protected override void OnInitialized()
        //{
        //    Valeur = 5;
        //}

        public void Increment()
        {
            Valeur++;
        }

        public void Decrement()
        {
            Valeur--;
        }
        public void AddValue()
        {
            Valeurs.Add(Valeur);
            _js.InvokeVoidAsync("localStorage.setItem","toto", Valeur);
        }

        public bool stopIncrement()
        {
            return Valeur >= 10;
        }
    }
}
