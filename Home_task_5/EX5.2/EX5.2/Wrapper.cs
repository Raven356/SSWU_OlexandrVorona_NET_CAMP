using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5._2
{
    internal class Wrapper
    {
        private List<string> _path = new List<string>();
        private Box _box;

        public Box Box { get { return _box; } }

        public void Wrap(SuperMarket superMarket)
        {
            _box = new Box(superMarket.Name, new List<Box>());
            for(int i = 0; i < superMarket.Divisions.Count; i++)
            {
                _box.Boxes.Add(new Box(superMarket[i].Name, new List<Box>()));
                if (superMarket[i].Subdivisions is not null)
                {
                    WrapBoxes(superMarket[i].Subdivisions, _box.Boxes[_box.Boxes.Count - 1]);
                }
                else
                {

                    AddGoods(superMarket[i].Goods, _box.Boxes[_box.Boxes.Count - 1]);
                    //_path.Add($"{superMarket.Name} -> {superMarket[i].Name}");
                }
                _box.Boxes[_box.Boxes.Count - 1].Size = _box.Boxes[_box.Boxes.Count - 1].GetSizeOfSubBoxes();
            }
            _box.Size = _box.GetSizeOfSubBoxes();
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
                box.Boxes[box.Boxes.Count - 1].Size = box.Boxes[box.Boxes.Count - 1].GetSizeOfSubBoxes();
            }
            box.Size = box.GetSizeOfSubBoxes();
        }

        private void AddGoods(List<Goods> goods, Box box)
        {
            double size = 0;
            for(int i = 0; i < goods.Count;i++)
            {
                box.Boxes.Add(new Box(goods[i]));
                size += goods[i].Size;
            }
            box.Size = size;
        }

    }
}
