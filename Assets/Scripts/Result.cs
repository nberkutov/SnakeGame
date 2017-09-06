using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[Serializable]
public class Result
{
    public string name;
    public int score;

    public Result()
    {

    }

    public Result(string _name, int _score)
    {
        name = _name;
        score = _score;
    }
}
