  public CurveKey this[int index]
        {
            get { return _keys[index]; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException();

                if (index >= _keys.Count)
                    throw new IndexOutOfRangeException();

                if (_keys[index].Position == value.Position)
                    _keys[index] = value;
                else
                {
                    _keys.RemoveAt(index);
                    _keys.Add(value);
                }
            }
        }
//hello

  public class DrawableGameComponent : GameComponent, IDrawable
    {
        private bool _initialized;
        private bool _disposed;
        private int _drawOrder;
        private bool _visible = true;
