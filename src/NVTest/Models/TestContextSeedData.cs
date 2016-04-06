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
			if(!_context.Questions.Any())
			{
				List<Question> Questions = new List<Question>();
				Questions.Add(new Question { QuestionNumber = 1, QuestionText = "A car driving through a parking lot splashes water on you. You feel like", firstChoice = "Making him apologize and pay for damages", secondChoice = "Telling him to be more careful in the future", isRelevant = true, nvChoice = 2 });
				Questions.Add(new Question { QuestionNumber = 2, QuestionText = "The more I think of how bad someone's actions or thoughts are", firstChoice = "The more I try to understand how to get along with that person", secondChoice = "The more I get irritated and want to tell that person off", isRelevant = true, nvChoice = 1 });
				Questions.Add(new Question { QuestionNumber = 3, QuestionText = "My reaction to groups is", firstChoice = "I like the feeling of belonging to a social group", secondChoice = "For some reason I don't really like groups", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 4, QuestionText = "If someone keeps bothering me even though I ask him/her to stop, I will", firstChoice = "Lose control", secondChoice = "Control myself", isRelevant = true, nvChoice = 2 });
				Questions.Add(new Question { QuestionNumber = 5, QuestionText = "I think of myself first of all as ", firstChoice = "An individual person", secondChoice = "A social being responsible to society and those like me.", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 6, QuestionText = "When a stranger hurts me I believe", firstChoice = "Forgive and forget is the best policy", secondChoice = "A tooth for a tooth and an eye for an eye is the best policy", isRelevant = true, nvChoice = 1 });
				Questions.Add(new Question { QuestionNumber = 7, QuestionText = "Workers on an unlawful strike should be", firstChoice = "Approached and a compromise should be negotiated", secondChoice = "Fired without notice", isRelevant = true, nvChoice = 1 });
				Questions.Add(new Question { QuestionNumber = 8, QuestionText = "Being different from my friends", firstChoice = "Makes me feek uncomfortable", secondChoice = "Does not bother; I like it", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 9, QuestionText = "When someone is rude to me", firstChoice = "Be rude back to the person", secondChoice = "Overcome the temptation to be rude", isRelevant = true, nvChoice = 2 });
				Questions.Add(new Question { QuestionNumber = 10, QuestionText = "I am inspired by", firstChoice = "Ideas", secondChoice = "Some people", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 11, QuestionText = "If I were in charge and some high officials were found guilty of taking bribes I would", firstChoice = "Pardon them with minimum punishment if they apologized", secondChoice = "Publicly humiliate physically punish these people", isRelevant = true, nvChoice = 1 });
				Questions.Add(new Question { QuestionNumber = 12, QuestionText = "If someone breaks something that belongs to me", firstChoice = "I will probably become enraged", secondChoice = "I understand that accidents happen", isRelevant = true, nvChoice = 2 });
				Questions.Add(new Question { QuestionNumber = 13, QuestionText = "I consider myself to ", firstChoice = "Be like everyone else", secondChoice = "Be different from everyone else", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 14, QuestionText = "Judgments about me", firstChoice = "Should be made on my own merits", secondChoice = "Should be made according to the people I associate with", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 15, QuestionText = "Lawbreakers must be", firstChoice = "Brought to justice, yet to be dealt with mercifully", secondChoice = "Severely punished", isRelevant = true, nvChoice = 1 });
				Questions.Add(new Question { QuestionNumber = 16, QuestionText = "I am", firstChoice = "Loyal", secondChoice = "Independent", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 17, QuestionText = "A boy was very mischievous and would beat up other boys. I would ", firstChoice = "Kick him out of his group", secondChoice = "Try to change his habits", isRelevant = true, nvChoice = 2 });
				Questions.Add(new Question { QuestionNumber = 18, QuestionText = "I am responsible to", firstChoice = "Other people, those I love, and those who depend on me", secondChoice = "Myself, my idels, and my ambitions", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 19, QuestionText = "When I hold a poor opinion of a person", firstChoice = "I do not try to hide the way I feel", secondChoice = "I try to hide my feelings and improve them without their knowing", isRelevant = true, nvChoice = 2 });
				Questions.Add(new Question { QuestionNumber = 20, QuestionText = "Criminals that are physically abused ", firstChoice = "Deserve it", secondChoice = "Should not be abused", isRelevant = true, nvChoice = 2 });
				Questions.Add(new Question { QuestionNumber = 21, QuestionText = "My reaction to crowds is", firstChoice = "I dislike crowds", secondChoice = "I enjoy the excitement of crowds", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 22, QuestionText = "If an employee refused to follow orders I would", firstChoice = "Threaten to fire him unless he did what he was told", secondChoice = "Persuade him to do what he was told", isRelevant = true, nvChoice = 2 });
				Questions.Add(new Question { QuestionNumber = 23, QuestionText = "I admire", firstChoice = "No one very much", secondChoice = "Some people, and would not question their opinion", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 24, QuestionText = "I see myself as", firstChoice = "An important person", secondChoice = "A social person", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 25, QuestionText = "A person who commits a murder should be", firstChoice = "Placed in a rehabilitation program and given minimum punishment", secondChoice = "Put on death row", isRelevant = true, nvChoice = 1 });
				Questions.Add(new Question { QuestionNumber = 26, QuestionText = "I like to ", firstChoice = "Get to know people", secondChoice = "Be alone", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 27, QuestionText = "Governments should deal with rebellious people by", firstChoice = "Punishing them", secondChoice = "Treating them in a humane way", isRelevant = true, nvChoice = 2 });
				Questions.Add(new Question { QuestionNumber = 28, QuestionText = "I like a person", firstChoice = "To say he/she is a good person provided they are", secondChoice = "To be modest, even if they are good", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 29, QuestionText = "When someone does something bad to me", firstChoice = "I will get back at them if I can, just because of the principle of the matter", secondChoice = "I do not get back at them, but try to show them their mistakes", isRelevant = true, nvChoice = 2 });
				Questions.Add(new Question { QuestionNumber = 30, QuestionText = "I have confidence in ", firstChoice = "Myself", secondChoice = "Things I and others like me represent", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 31, QuestionText = "When a person makes fun of me, I ", firstChoice = "Try to convince the person that it is not always good to make fun of others", secondChoice = "Retaliate", isRelevant = true, nvChoice = 1 });
				Questions.Add(new Question { QuestionNumber = 32, QuestionText = "I live for", firstChoice = "The good of everyone else", secondChoice = "Myself", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 33, QuestionText = "If someone criticizes me, I", firstChoice = "Do not criticize them back; rather I defense myself with good arguments", secondChoice = "I find it best to criticize the person back", isRelevant = true, nvChoice = 1 });
				Questions.Add(new Question { QuestionNumber = 34, QuestionText = "Sex crimes such as rape and attacks on children deserve", firstChoice = "Imprisonment and psychiatric care", secondChoice = "More than mere imprisonment, such criminals ought to be punished or worse", isRelevant = true, nvChoice = 1 });
				Questions.Add(new Question { QuestionNumber = 35, QuestionText = "When a friend does me a favor ", firstChoice = "I feel that I must return the favor", secondChoice = "I do not feel that I must return the favor", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 36, QuestionText = "Sometimes, when my parents scolded me I ", firstChoice = "Showed resentment", secondChoice = "Tried to reason with myself to understand why they acted that as they did", isRelevant = true, nvChoice = 2 });
				Questions.Add(new Question { QuestionNumber = 37, QuestionText = "I like to", firstChoice = "Give gifts", secondChoice = "Receive gifts", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 38, QuestionText = "When I am disturbed by another, say, while studying", firstChoice = "My first reaction will be to get angry", secondChoice = "I will explain to the person I do not want to be bothered", isRelevant = true, nvChoice = 2 });
				Questions.Add(new Question { QuestionNumber = 39, QuestionText = "The majority of my schoolwork involves", firstChoice = "Reading", secondChoice = "Writing", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 40, QuestionText = "If a person skips me in line", firstChoice = "I will pass him and stand ahead of him", secondChoice = "I will persuade him to go back", isRelevant = true, nvChoice = 2 });
				Questions.Add(new Question { QuestionNumber = 41, QuestionText = "When I was younger", firstChoice = "I did not care to be a member of a crowd or gang", secondChoice = "I was always a follower", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 42, QuestionText = "If students misbehave in school, the teachers should", firstChoice = "Punish them as needed", secondChoice = "Think of things they may have done to cause their behavior", isRelevant = true, nvChoice = 2 });
				Questions.Add(new Question { QuestionNumber = 43, QuestionText = "If a teacher grades me unfairly", firstChoice = "Complain to my friends", secondChoice = "Seek an explanation", isRelevant = true, nvChoice = 2 });
				Questions.Add(new Question { QuestionNumber = 44, QuestionText = "If someone harms my family", firstChoice = "Retaliate", secondChoice = "Make them understand what they did", isRelevant = true, nvChoice = 2 });
				Questions.Add(new Question { QuestionNumber = 45, QuestionText = "If my friend has a problem I would like to ", firstChoice = "Counsel that friend on his problem", secondChoice = "Recommend that my friend see a counselor", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 46, QuestionText = "I like ", firstChoice = "Team sports", secondChoice = "Individual sports", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 47, QuestionText = "If a judge were found guilty of corruption, I would recommend", firstChoice = "A stronger penalty for him than for a common citizen", secondChoice = "The same penalty for him as for a common citizen", isRelevant = true, nvChoice = 2 });
				Questions.Add(new Question { QuestionNumber = 48, QuestionText = "I am", firstChoice = "Forgetful", secondChoice = "Organized", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 49, QuestionText = "Our nation's history is glorified by", firstChoice = "Great fighters and conquerors", secondChoice = "Great writers and social reformers", isRelevant = true, nvChoice = 2 });
				Questions.Add(new Question { QuestionNumber = 50, QuestionText = "I follow", firstChoice = "Ethical standards", secondChoice = "My conscience", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 51, QuestionText = "All citizens should be allowed to carry weapons", firstChoice = "Only when there is a war", secondChoice = "To defend themselves", isRelevant = true, nvChoice = 1 });
				Questions.Add(new Question { QuestionNumber = 52, QuestionText = "My attitude about groups is ", firstChoice = "I do not join groups", secondChoice = "I am proud to be in some groups", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 53, QuestionText = "If a teacher is involved in a sex crime involving a student, s/he should be given", firstChoice = "A harsher punishment than usual to set an example for other teachers", secondChoice = "The same treatment as someone who was not a teacher", isRelevant = true, nvChoice = 2 });
				Questions.Add(new Question { QuestionNumber = 54, QuestionText = "I look forward to social events with", firstChoice = "Parents and relatives", secondChoice = "Friends and neighbors", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 55, QuestionText = "I like instructions to be ", firstChoice = "General", secondChoice = "Specific", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 56, QuestionText = "A good social system needs", firstChoice = "Rugged and tough discipline", secondChoice = "People who can tolerate others", isRelevant = true, nvChoice = 2 });
				Questions.Add(new Question { QuestionNumber = 57, QuestionText = "A clergyman who is involved in immoral behavior should", firstChoice = "Be allowed to return to his position at the church after he repents and changes his ways", secondChoice = "Never be allowed to return to his position at the church", isRelevant = true, nvChoice = 1 });
				Questions.Add(new Question { QuestionNumber = 58, QuestionText = "I appreciate", firstChoice = "Music", secondChoice = "Art", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 59, QuestionText = "When I see a parade go by I ", firstChoice = "Enjoy watching it but have no desire to be in it", secondChoice = "Wish I could be in it ", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 60, QuestionText = "When I am in a bad mood I", firstChoice = "Feel like smashing things", secondChoice = "Relax and tell myself things will get better", isRelevant = true, nvChoice = 2 });
				Questions.Add(new Question { QuestionNumber = 61, QuestionText = "People who drink and drive should", firstChoice = "Be imprisoned and severely fined", secondChoice = "Undergo counseling and education on the effects of alcohol and drug abuse", isRelevant = true, nvChoice = 2 });
				Questions.Add(new Question { QuestionNumber = 62, QuestionText = "I would rather watch", firstChoice = "Mystery movies", secondChoice = "Humorous movies", isRelevant = false });
				Questions.Add(new Question { QuestionNumber = 63, QuestionText = "If someone I know is engaging in deviant behavior I feel I should", firstChoice = "Tell him that what he is doing is wrong, then talk him out of doing it", secondChoice = "Let him do what he wants as long as I am not affected", isRelevant = true, nvChoice = 1 });
				Questions.Add(new Question { QuestionNumber = 64, QuestionText = "If a country is supporting terrorist acts, I think the country should be ", firstChoice = "Attacked by military action until these acts end", secondChoice = "Persuaded through negotiations to withdraw their support of terrorism", isRelevant = true, nvChoice = 2 });
				Questions.Add(new Question { QuestionNumber = 65, QuestionText = "People who try to force their religious beliefs on others should be", firstChoice = "Ignored until they are ready to listen to others' beliefs", secondChoice = "Asked to leave and threatened if they refuse to go", isRelevant = true, nvChoice = 1 });

				foreach (Question question in Questions)
				{
					_context.Add(question);
				}
				_context.SaveChanges();
			}

		}
	}
}