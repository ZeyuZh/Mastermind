using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace Ksu.Cis300.Mastermind
{
    public class DecisionTree
    {
        /// <summary>
        /// A string giving the guess at this node.
        /// </summary>
        private string _guess;

        /// <summary>
        ///  giving the children. 
        /// </summary>
        private DecisionTree[,] _children = new DecisionTree[5,5];

        /// <summary>
        /// A public property to get the guess
        /// </summary>
        public string Guess
        {
            get
            {
                return _guess;
            }
        }

        /// <summary>
        /// a constructor to read the whole decision tree.
        /// </summary>
        /// <param name="reader"> an XmlReader used to read the file</param>
        public DecisionTree(XmlReader reader)
        {
            string code = reader.GetAttribute("guess");
            if (!Scorer.CodeIsValid(code))
            {
                throw new IOException("Invalid guess found: " + code);
            }
            _guess = reader.GetAttribute("guess");
            while (reader.Read() && reader.NodeType == XmlNodeType.Element)
            {
                int black = Convert.ToInt32(reader.GetAttribute("black-hits"));
                int white = Convert.ToInt32(reader.GetAttribute("white-hits"));
                if(_children[black,white] != null)
                {
                    throw new IOException("Two guesses are given for the same score.");
                }
                if (reader.Name != "node")
                {
                    throw new IOException("An element has a name other than node");
                }
                _children[black,white] = new DecisionTree(reader);        
            }
            if(reader.NodeType != XmlNodeType.EndElement)
            {
                throw new IOException("Invalid XML node type found.");
            }       
        }

        /// <summary>
        /// A public method to get a child for known blackhits and whitehits
        /// </summary>
        /// <param name="black">the number of black hits</param>
        /// <param name="white">the number of white hits</param>
        /// <returns></returns>
        public DecisionTree GetChild(int black, int white)
        {
            return _children[black, white];
        }
    }
}
