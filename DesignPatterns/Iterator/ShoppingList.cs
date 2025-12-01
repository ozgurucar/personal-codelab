public class ShoppingList
{

    private List<string> _list = new();

    public List<string> GetShoppingList()
    {
        return _list;
    }

    public void Push(string item)
    {
        _list.Add(item);
    }

    public string Pop()
    {
        string item = _list.Last();
        _list.Remove(item);
        return item;
    }

    public IIterator<string> CreateIterator() 
    {
        return new ListIterator(this);
    }
 
    private class ListIterator : IIterator<string>
    {
        private ShoppingList _shoppingList;

        private int _index;

        public ListIterator(ShoppingList shoppingList)
        {
            _shoppingList = shoppingList;
            _index = 0;
        }
        
        public string Current()
        {
            return _shoppingList._list[_index];
        }

        public bool HasNext()
        {
            return _index < _shoppingList._list.Count();
        }

        public void Next()
        {
            _index++;
        }
    }
}