using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingAdventureProgram
{
    abstract class LevelInfo
    {
        protected List<string> levels = new List<string>();
        public LevelInfo()
        {

        }
    }

    class Level1Info : LevelInfo
    {
        public Level1Info()
        {
            levels.Add("You can decide what you want to do in life, but I suggest doing something that creates. Something that leaves a tangible thing once you're done. That way even after you're gone, you will still live on in the things you created.");
            levels.Add("Patricia's friend who was here hardly had any issues at all, but she wasn't telling the truth. Yesterday, before she left to go home, she heard that her husband is in the hospital and pretended to be surprised. It later came out that she was the person who had put him there.");
            levels.Add("The box sat on the desk next to the computer. It had arrived earlier in the day and business had interrupted her opening it earlier. She didn't who had sent it and briefly wondered who it might have been. As she began to unwrap it, she had no idea that opening it would completely change her life.");
        }
    }

    class Level2Info : LevelInfo
    {
        public Level2Info()
        {
            levels.Add("There were about twenty people on the dam. Most of them were simply walking and getting exercise. There were a few who were fishing. There was a family who had laid down a blanket and they were having a picnic. It was like this most days and nothing seemed out of the ordinary. The problem was that nobody noticed the water leaking through the dam wall.");
            levels.Add("It was their first date and she had been looking forward to it the entire week. She had her eyes on him for months, and it had taken a convoluted scheme with several friends to make it happen, but he'd finally taken the hint and asked her out. After all the time and effort she'd invested into it, she never thought that it would be anything but wonderful. It goes without saying that things didn't work out quite as she expected.");
            levels.Add("It really doesn't matter what she thinks as it isn't her problem to solve. That's what he kept trying to convince himself. She was trying to insert her opinion where it wasn't wanted or welcome. He already had a plan and even though that plan didn't correspond with what she wanted him to do or what should be done, it wasn't her decision to make. The question now became whether he would stick to his convictions and go through with his plan knowing she wouldn't approve. He knew she would be upset and there would be consequences, but he had to do what he felt was right. He couldn't allow her to control him.");
        }
    }

    class Level3Info : LevelInfo
    {
        public Level3Info()
        {
            levels.Add("Time is all relative based on age and experience. When you are a child an hour is a long time to wait but a very short time when that’s all the time you are allowed on your iPad. As a teenager time goes faster the more deadlines you have and the more you procrastinate. As a young adult, you think you have forever to live and don’t appreciate the time you spend with others. As a middle-aged adult, time flies by as you watch your children grow up. And finally, as you get old and you have fewer responsibilities and fewer demands on you, time slows. You appreciate each day and are thankful you are alive. An hour is the same amount of time for everyone yet it can feel so different in how it goes by.");
            levels.Add("Was it a whisper or was it the wind? He wasn't quite sure. He thought he heard a voice but at this moment all he could hear was the wind rustling the leaves of the trees all around him. He stopped and listened more intently to see if he could hear the voice again. Nothing but the wind rustling the leaves could be heard. He was about to continue his walk when he felt a hand on his shoulder, and he quickly turned to see who it was. There was nobody there, but he heard the voice again.");
            levels.Add("The sun was setting and the sky turned a brilliant array of colors. The oranges and reds lit up the sky and the water below. The sun was almost completely below the horizon now and the colors were fading to pastel hues. The water was calm and the boats in the harbor were gently rocking in the breeze. It was a beautiful sight and he was glad he had decided to take a walk to the harbor. He had almost stayed home and watched TV, but something had told him to go out and enjoy the evening. He was glad he had listened to that voice inside him. He would have missed this beautiful sunset if he hadn't gone out. He stood there for a few more minutes until the sun was completely below the horizon and the colors had faded to grays and blues. Then he turned and walked back home.");
        }
    }
}