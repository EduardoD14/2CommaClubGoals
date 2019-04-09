using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwoCommaClubGoals.Entities
{
    public class Cart
    {        
            private List<CartLine> lineCollection = new List<CartLine>();
            public void AddItem(Lesson lesson, int quantity)
            {
                CartLine line = lineCollection
                    .Where(p => p.Lesson.lessonID == lesson.lessonID)
                    .FirstOrDefault();
                if (line == null)
                {
                    lineCollection.Add(new CartLine
                    {
                        Lesson = lesson,
                        Quantity = quantity
                    });
                }
                else
                {
                    line.Quantity += quantity;
                }
            }
            public void RemoveLine(Lesson Lesson)
            {
                lineCollection.RemoveAll(l => l.Lesson.lessonID == Lesson.lessonID);
            }
            public decimal ComputeTotalValue()
            {
                return lineCollection.Sum(e => e.Lesson.Price * e.Quantity);
            }
            public void Clear()
            {
                lineCollection.Clear();
            }
            public IEnumerable<CartLine> Lines
            {
                get { return lineCollection; }
            }
        }
        public class CartLine
        {
            public Lesson Lesson { get; set; }
            public int Quantity { get; set; }
        }
    }
