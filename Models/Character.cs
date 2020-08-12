using System;

namespace kingsmen.Models
{
    /*
    Variable | Definition
    ---|---------
    `page_id` | The unique identifier for that characters page within the wikia
    `name` | The name of the character
    `urlslug` | The unique url within the wikia that takes you to the character
    `ID` | The identity status of the character (Secret Identity, Public identity, [on marvel only: No Dual Identity])
    `ALIGN` | If the character is Good, Bad or Neutral
    `EYE` | Eye color of the character
    `HAIR` | Hair color of the character
    `SEX` | Sex of the character (e.g. Male, Female, etc.)
    `GSM` | If the character is a gender or sexual minority (e.g. Homosexual characters, bisexual characters)
    `ALIVE` | If the character is alive or deceased
    `APPEARANCES` | The number of appareances of the character in comic books (as of Sep. 2, 2014. Number will become increasingly out of date as time goes on.)
    `FIRST APPEARANCE` | The month and year of the character's first appearance in a comic book, if available
    `YEAR` | The year of the character's first appearance in a comic book, if available
    */
    public class Character
    {
        public int Id { get; set; }

        public string PageId { get; set; }

        public string Name { get; set; }

        public string UrlSlug { get; set; }

        public string SecretIdentity { get; set; }

        public string Align { get; set; }

        public string Eye { get; set; }

        public string Hair { get; set; }

        public string Sex { get; set; }

        public string GSM { get; set; }

        public string Alive { get; set; }

        public string Appearances { get; set; }

        public string FirstAppearanceDate { get; set; }

        public string FirstAppearanceYear { get; set; }
    }
}
