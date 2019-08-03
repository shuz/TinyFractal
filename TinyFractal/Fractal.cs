using System;
using System.Collections.Generic;
using System.Text;

namespace TinyFractal
{
    public class Fractal : IFractal, IEnumerable<IMappingMaker>
    {
        private static Random rand = new Random();

        private List<IMapping> mappings;
        private List<IMappingMaker> mappingMakers;

        private List<Line2D> iteration;

        private void Initialize()
        {
            if (mappings == null)
            {
                mappings = new List<IMapping>();
                foreach (IMappingMaker maker in mappingMakers)
                {
                    mappings.Add(maker.Create());
                }
            }
        }

        public Fractal(List<IMappingMaker> mappingMakers)
        {
            this.mappingMakers = mappingMakers;
            Initialize();
        }

        public IList<IMapping> Mappings
        {
            get
            {
                return mappings.AsReadOnly();
            }
        }

        public IList<Line2D> Iteration
        {
            get
            {
                if (iteration != null)
                {
                    return iteration.AsReadOnly();
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
                    iteration = new List<Line2D>();
                    iteration.AddRange(value);
                }
                else
                {
                    iteration = null;
                }
            }
        }

        public void Iterate()
        {
            List<Line2D> newIteration = new List<Line2D>();
            foreach (IMapping map in mappings)
            {
                foreach (Line2D line in iteration)
                {
                    newIteration.Add(new Line2D(map.Map(line.Begin), map.Map(line.End)));
                }
            }
            this.iteration = newIteration;
        }

        public Point2D RandomTrace(Point2D point)
        {
            int mapidx = rand.Next(mappings.Count);
            return mappings[mapidx].Map(point);
        }

        public static Fractal Parse(string s)
        {
            string[] splitted = s.Trim().Split(';');
            List<IMappingMaker> mappingMakers = new List<IMappingMaker>();

            foreach (string smapping in splitted)
            {
                if (!string.IsNullOrEmpty(smapping))
                {
                    mappingMakers.Add(SimilitudeMappingMaker.Parse(smapping));
                }
            }

            return new Fractal(mappingMakers);
        }

        #region IEnumerable<IMappingMaker> Members

        public IEnumerator<IMappingMaker> GetEnumerator()
        {
            return mappingMakers.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return mappingMakers.GetEnumerator();
        }

        #endregion
    }
}
