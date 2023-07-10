using STgenetics.Farm.Client.Models.Request;
using STgenetics.Farm.Client.Models.Response;

namespace STgenetics.Farm.Client.Services
{
    public class AnimalAppState
    {
        public Action<AnimalSearchCriteria> OnSearch { get; set; }

        public Action<List<AnimalResponse>> OnChangeAnimalsCart { get; set; }

        public List<AnimalResponse> animalsInCart { get; private set; } = new List<AnimalResponse>();

        public void NotifyAnimalSearch(AnimalSearchCriteria criteria)
        {
            if (criteria == null)
                return;

            OnSearch?.Invoke(criteria);
        }

        public void AddAnimalToCart(AnimalResponse animal)
        {
            if (animal == null)
                return;

            animalsInCart.Add(animal);

            OnChangeAnimalsCart?.Invoke(animalsInCart);
        }

        public void RemoveAnimalToCart(AnimalResponse animal)
        {
            if (animalsInCart.Find(x => x.Id == animal.Id) == null)
                return;

            animalsInCart.Remove(animal);

            OnChangeAnimalsCart?.Invoke(animalsInCart);
        }

    }
}
