using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MiniChallenge_5_7_Enndpoints_MVC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MultiEndpointPastProjects : ControllerBase
    {
        
        [HttpGet("/MadLibMadness")]
        public string MadLibMadness(string Name, string Location, string VerbOne, string VerbTwo, string Adverb, string Noun, string Adjective)
        {
            string madLibText = $"Last year, this very dashing person named {Name}, had to {VerbOne} toward the highly recognizable park in {Location} and had to {Adverb} {VerbTwo} a {Adjective} {Noun} as fast as they could. Everyone became uneasy at how crazy the whole situation was.  {Name} was forever known as the {Adverb} {Noun} {VerbTwo}er.";
            return madLibText;
        }

        [HttpGet("/OddOrEven")]
        // works for integers 0 or greater
        public string OddOrEven(int x = 5){
            string answer;
            if(x%2 == 1){
                answer = "odd";
            }
            else{
                answer = "even";
            }
            return $"The number you chose is {answer}!";
        }

        [HttpGet("/ReverseItAll")]
            public string ReverseItAll(string userInput)
            {
                if (string.IsNullOrEmpty(userInput))
                    return "User input is necessary";

                char[] changeToCharArray = userInput.ToCharArray();
                Array.Reverse(changeToCharArray);
                
                string reversed = new string (changeToCharArray);

                return "Your original input was:  " + userInput + "!\nYour input reversed is:  " + reversed + "!";
            }

        [HttpGet("/ReverseItNumbersOnly")]
        public string ReverseItNumbersOnly(string input)
        {
            if (string.IsNullOrEmpty(input))
                return "Input is required";

            if (!input.All(char.IsDigit))
                return "Error:  Input must be an integer";

            char[] changeToCharArray = input.ToCharArray();
            Array.Reverse(changeToCharArray);

            string reversed = new string(changeToCharArray);

            return "Your original input is:  " + input + " \nYour input reversed is:  " + reversed;
        }
    }
}