using System;
using System.Collections.Generic;
using MGWinForms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Windows.Forms;

namespace ExampleControl
{
    class SelectedCellsControl : GraphicsDeviceControl
    {
        private int _cellSize = 32;
        private int _cellSpacing = 2;
        private Color _glowColor = Color.Cyan;
        private Color _hoverColor = Color.Purple;

        private Tuple<int, int> _hover;
        private HashSet<Tuple<int, int>> _selected;

        private SpriteBatch _spriteBatch;
        private Texture2D _whiteTex;

        protected override void Initialize ()
        {
            _selected = new HashSet<Tuple<int, int>>();

            _spriteBatch = new SpriteBatch(GraphicsDevice);
            _whiteTex = SolidColorTexture(GraphicsDevice, Color.White);
        }

        protected override void Draw ()
        {
            GraphicsDevice.Clear(Color.Black);

            _spriteBatch.Begin();

            foreach (var coord in _selected) {
                int x = coord.Item1 * (_cellSize + _cellSpacing);
                int y = coord.Item2 * (_cellSize + _cellSpacing);

                _spriteBatch.Draw(_whiteTex, new Rectangle(x, y, _cellSize, _cellSize), _glowColor);
            }

            if (_hover != null) {
                int x = _hover.Item1 * (_cellSize + _cellSpacing);
                int y = _hover.Item2 * (_cellSize + _cellSpacing);

                _spriteBatch.Draw(_whiteTex, new Rectangle(x, y, _cellSize, _cellSize), _hoverColor);
            }

            _spriteBatch.End();
        }

        public void SetColor (string color)
        {
            _glowColor = TranslateColor(color);

            Invalidate();
        }

        private Color TranslateColor (string color)
        {
            switch (color) {
                case "Blue": return Color.Blue;
                case "Cyan": return Color.Cyan;
                case "Green": return Color.Green;
                case "Magenta": return Color.Magenta;
                case "Red": return Color.Red;
                case "Yellow": return Color.Yellow;
                default: return Color.White;
            }
        }

        protected override void OnMouseMove (MouseEventArgs e)
        {
            _hover = ConvertCoord(e.Location);

            base.OnMouseMove(e);

            Invalidate();
        }

        protected override void OnMouseClick (MouseEventArgs e)
        {
            Tuple<int, int> coord = ConvertCoord(e.Location);

            if (_selected.Contains(coord))
                _selected.Remove(coord);
            else
                _selected.Add(coord);

            base.OnMouseClick(e);

            Invalidate();
        }

        protected override void OnMouseLeave (EventArgs e)
        {
            _hover = null;

            base.OnMouseLeave(e);

            Invalidate();
        }

        private Tuple<int, int> ConvertCoord (System.Drawing.Point location)
        {
            int gridSize = _cellSize + _cellSpacing;

            int cellX = location.X / gridSize;
            int cellY = location.Y / gridSize;

            if (cellX % gridSize >= _cellSize || cellY % gridSize >= _cellSize)
                return null;
            else
                return new Tuple<int, int>(cellX, cellY);
        }

        private static Texture2D SolidColorTexture (GraphicsDevice device, Color color)
        {
            Texture2D tex = new Texture2D(device, 1, 1);
            Color[] data = new Color[1] { color };

            tex.SetData(data);
            return tex;
        }
    }


}
