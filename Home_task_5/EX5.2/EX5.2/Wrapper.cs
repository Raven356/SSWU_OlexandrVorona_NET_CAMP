using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5._2
{
    internal class Wrapper
    {
        private Box _box;

        public Box Box { get { return _box; } }

        public void Wrap(SuperMarket superMarket)
        {
            _box = new Box(superMarket.Name, new List<Box>());
            WrapBoxes(superMarket.Divisions, _box);
        }

        private void WrapBoxes(List<Division> divisions, Box box)
        {
            for(int i = 0; i < divisions.Count; i++)
            {
                box.Boxes.Add(new Box(divisions[i].Name, new List<Box>()));
                if (divisions[i].Subdivisions is not null)
                {
                    WrapBoxes(divisions[i].Subdivisions, box.Boxes[box.Boxes.Count - 1]);
                }
                else
                {
                    AddGoods(divisions[i].Goods, box.Boxes[box.Boxes.Count - 1]);
                }
                box.Height = box.GetHeightOfSubBoxes();
                box.Width = box.GetWidth();
                box.Length = box.GetLength();
            }
            box.Boxes[box.Boxes.Count - 1].Height = box.Boxes[box.Boxes.Count - 1].GetHeightOfSubBoxes();
            box.Boxes[box.Boxes.Count - 1].Width = box.Boxes[box.Boxes.Count - 1].GetWidth();
            box.Boxes[box.Boxes.Count - 1].Length = box.Boxes[box.Boxes.Count - 1].GetLength();
        }

        private void AddGoods(List<Goods> goods, Box box)
        {
            double height = 0;
            for(int i = 0; i < goods.Count;i++)
            {
                box.Boxes.Add(new Box(goods[i]));
                height += goods[i].Height;
            }
            box.Height = height;
            box.Length = goods.Max(x => x.Length);
            box.Width = goods.Max(x => x.Width);
        }

    }
}
