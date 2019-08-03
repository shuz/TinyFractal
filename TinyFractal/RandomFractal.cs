using System;
using System.Collections.Generic;
using System.Text;

namespace TinyFractal
{
    public class RandomFractal : IFractal, IEnumerable<RandomFractal.MappingItem>
    {
        private static Random random = new Random();

        private List<MappingItem> mappings;
        private double sum;

        private List<List<Line2D>> iteration;
        private int imageCount;
        private int currentImage;

        public class MappingItem
        {
            private Fractal fractal;
            private double probablity;

            public MappingItem(Fractal fractal, double probablity)
            {
                this.fractal = fractal;
                this.probablity = probablity;
            }

            public Fractal Fractal
            {
                get { return fractal; }
            }

            public double Probablity
            {
                get { return probablity; }
            }
        }


        public RandomFractal(IList<MappingItem> mappings)
        {
            this.mappings = new List<MappingItem>();
            this.mappings.AddRange(mappings);

            foreach (MappingItem item in mappings)
            {
                sum += item.Probablity;
            }

            imageCount = mappings.Count;
        }

        public int CurrentImage
        {
            get
            {
                return currentImage;
            }
            set
            {
                currentImage = value;
            }
        }

        public int ImageCount
        {
            get
            {
                return imageCount;
            }
            set
            {
                imageCount = value;
            }
        }

        public IList<Line2D> Iteration
        {
            get
            {
                if (iteration != null)
                {
                    if (currentImage == -1)
                    {
                        currentImage = random.Next(iteration.Count);
                    }
                    return iteration[currentImage].AsReadOnly();
                }
                else
                {
                    return null;
                }
            }

            set
            {
                if (value != null)
                {
                    iteration = new List<List<Line2D>>();
                    for (int i = 0; i < imageCount; ++i)
                    {
                        iteration.Add(new List<Line2D>(value));
                    }
                }
                else
                {
                    iteration = null;
                }
            }
        }

        public void Iterate()
        {
            List<List<Line2D>> newImages = new List<List<Line2D>>();

            for (int i = 0; i < iteration.Count; ++i)
            {
                Fractal fractal = RandomSelect();

                List<Line2D> newImage = new List<Line2D>();
                foreach (IMapping mapping in fractal.Mappings)
                {
                    List<Line2D> image = iteration[random.Next(iteration.Count)];

                    foreach (Line2D line in image)
                    {
                        newImage.Add(new Line2D(mapping.Map(line.Begin), mapping.Map(line.End)));
                    }
                }

                newImages.Add(newImage);
            }

            iteration = newImages;
        }

        public override string ToString()
        {
            string result = string.Empty;

            foreach (MappingItem item in mappings)
            {
                result += string.Format("{ {0} | {1} } ", item.Fractal, item.Probablity);
            }

            return result;
        }

        public static RandomFractal Parse(string s)
        {
            List<MappingItem> mappings = new List<MappingItem>();
            string[] splitted = s.Split('}');

            foreach (string smapping in splitted)
            {
                if (!string.IsNullOrEmpty(smapping))
                {
                    string[] pair = smapping.Trim().Substring(1).Split('|');

                    pair[0] = pair[0].Trim();
                    pair[1] = pair[1].Trim();

                    Fractal fractal = Fractal.Parse(pair[0]);
                    double probablity = double.Parse(pair[1]);

                    mappings.Add(new MappingItem(fractal, probablity));
                }
            }

            return new RandomFractal(mappings);
        }

        private Fractal RandomSelect()
        {
            double rand = random.NextDouble() * sum;
            double value = 0;

            foreach (MappingItem item in mappings)
            {
                value += item.Probablity;
                if (value >= rand)
                {
                    return item.Fractal;
                }
            }

            return null;
        }

        public Point2D RandomTrace(Point2D point)
        {
            return RandomSelect().RandomTrace(point);
        }

        #region IEnumerable<MappingItem> Members

        public IEnumerator<MappingItem> GetEnumerator()
        {
            return mappings.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return mappings.GetEnumerator();
        }

        #endregion
    }
}
