using System;
using System.Linq;
using System.Collections.Generic;

namespace NVTest.Models
{
	public class TestContextSeedData
	{
		private TestContext _context;

		public TestContextSeedData(TestContext context)
		{
			_context = context;
		}
		public void EnsureSeedData()
		{
			List<Question> Questions = new List<Question>();
			Questions.Add(new Question { Id = 1, QuestionText = "A car driving through a parking lot splashes water on you. You feel like", firstChoice = "Making him apologize and pay for damages", secondChoice = "Telling him to be more careful in the future", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 2, QuestionText = "The more I think of how bad someone's actions or thoughts are", firstChoice = "The more I try to understand how to get along with that person", secondChoice = "The more I get irritated and want to tell that person off", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 3, QuestionText = "My reaction to groups is", firstChoice = "I like the feeling of belonging to a social group", secondChoice = "For some reason I don't really like groups", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 4, QuestionText = "If someone keeps bothering me even though I ask him/her to stop, I will", firstChoice = "Lose control", secondChoice = "Control myself", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 5, QuestionText = "I think of myself first of all as ", firstChoice = "An individual person", secondChoice = "A social being responsible to society and those like me.", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 6, QuestionText = "When a stranger hurts me I believe", firstChoice = "Forgive and forget is the best policy", secondChoice = "A tooth for a tooth and an eye for an eye is the best policy", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 7, QuestionText = "Workers on an unlawful strike should be", firstChoice = "Approached and a compromise should be negotiated", secondChoice = "Fired without notice", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 8, QuestionText = "Being different from my friends", firstChoice = "Makes me feek uncomfortable", secondChoice = "Does not bother; I like it", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 9, QuestionText = "When someone is rude to me", firstChoice = "Be rude back to the person", secondChoice = "Overcome the temptation to be rude", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 10, QuestionText = "I am inspired by", firstChoice = "Ideas", secondChoice = "Some people", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 11, QuestionText = "If I were in charge and some high officials were found guilty of taking bribes I would", firstChoice = "Pardon them with minimum punishment if they apologized", secondChoice = "Publicly humiliate physically punish these people", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 12, QuestionText = "If someone breaks something that belongs to me", firstChoice = "I will probably become enraged", secondChoice = "I understand that accidents happen", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 13, QuestionText = "I consider myself to ", firstChoice = "Be like everyone else", secondChoice = "Be different from everyone else", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 14, QuestionText = "Judgments about me", firstChoice = "Should be made on my own merits", secondChoice = "Should be made according to the people I associate with", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 15, QuestionText = "Lawbreakers must be", firstChoice = "Brought to justice, yet to be dealt with mercifully", secondChoice = "Severely punished", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 16, QuestionText = "I am", firstChoice = "Loyal", secondChoice = "Independent", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 17, QuestionText = "A boy was very mischievous and would beat up other boys. I would ", firstChoice = "Kick him out of his group", secondChoice = "Try to change his habits", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 18, QuestionText = "I am responsible to", firstChoice = "Other people, those I love, and those who depend on me", secondChoice = "Myself, my idels, and my ambitions", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 19, QuestionText = "When I hold a poor opinion of a person", firstChoice = "I do not try to hide the way I feel", secondChoice = "I try to hide my feelings and improve them without their knowing", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 20, QuestionText = "Criminals that are physically abused ", firstChoice = "Deserve it", secondChoice = "Should not be abused", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 21, QuestionText = "My reaction to crowds is", firstChoice = "I dislike crowds", secondChoice = "I enjoy the excitement of crowds", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 22, QuestionText = "If an employee refused to follow orders I would", firstChoice = "Threaten to fire him unless he did what he was told", secondChoice = "Persuade him to do what he was told", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 23, QuestionText = "I admire", firstChoice = "No one very much", secondChoice = "Some people, and would not question their opinion", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 24, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 25, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 26, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 27, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 28, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 29, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 30, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 31, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 32, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 33, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 34, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 35, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 36, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 37, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 38, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 39, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 40, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 41, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 42, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 43, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 44, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 45, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 46, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 47, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 48, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 49, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 50, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 51, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 52, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 53, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 54, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 55, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 56, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 57, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 58, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 59, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 60, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 61, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 62, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 63, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 64, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
			Questions.Add(new Question { Id = 65, QuestionText = "", firstChoice = "", secondChoice = "", isRelevant = true, nvChoice = 1 });
		}
	}
}