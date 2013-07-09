using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Enums
{
    [Flags]
    public enum Genre
    {
        Action = 1 << 0,
        Adventure = 1 << 1,
        Animation = 1 << 2,
        Biography = 1 << 3,
        Comedy = 1 << 4,
        Crime = 1 << 5,
        Documentary = 1 << 6,
        Drama = 1 << 7,
        Family = 1 << 8,
        Fantasy = 1 << 9,
        FilmNoir = 1 << 10,
        Foreign = 1 << 11,
        FoundFootage = 1 << 12,
        Historical = 1 << 13,
        Horror = 1 << 14,
        Kids = 1 << 15,
        Mokumentary = 1 << 16,
        Musical = 1 << 17,
        Mystery = 1 << 18,
        Romance = 1 << 19,
        SciFi = 1 << 20,
        Thriller = 1 << 21,
        War = 1 << 22,
        Western = 1 << 23
    }
}
