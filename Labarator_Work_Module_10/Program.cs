using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labarator_Work_Module_10
{
    public class AudioSystem
    {
        public void TurnOn()
        {
            Console.WriteLine("Аудио система включена ");
        }
        public void SetVolume(int level)
        {
            Console.WriteLine($"Уровень аудиро системы {level}");
        }
        public void TurnOff()
        {
            Console.WriteLine("Аудио система выключена ");
        }

    }

    public class VideoProjector
    {
        public void TurnOn()
        {
            Console.WriteLine("Видео проектор включен");
        }
        public void SetResolution(string resolution)
        {
            Console.WriteLine($"Результат видео проекта {resolution}");
        }
        public void TurnOff()
        {
            Console.WriteLine("Видео проектор выключен");
        }
    }

    public class LightingSystem
    {
        public void TurnOn()
        {
            Console.WriteLine("Яркость включена ");
        }
        public void SetBrightness(int level)
        {
            Console.WriteLine($"Уровень яркости{level}");
        }
        public void TurnOff()
        {
            Console.WriteLine("Яркость отключена");
        }
    }

    public class HomeTheaterFacade
    {
        private AudioSystem audioSystem;
        private VideoProjector videoProjector;
        private LightingSystem lightingSystem;

        public HomeTheaterFacade(AudioSystem audioSystem, VideoProjector videoProjector, LightingSystem lightingSystem)
        {
            this.audioSystem = audioSystem;
            this.videoProjector = videoProjector;
            this.lightingSystem = lightingSystem;
        }

        public void StartMove()
        {
            Console.WriteLine("Подготовка к началу фильма");
            lightingSystem.TurnOn();
            lightingSystem.SetBrightness(5);
            audioSystem.TurnOn();
            audioSystem.SetVolume(8);
            videoProjector.TurnOn();
            videoProjector.SetResolution("HD");
            Console.WriteLine("Начала фильма");
        }

        public void EndMove()
        {
            Console.WriteLine("Выключение фильма");
            videoProjector.TurnOff();
            audioSystem.TurnOff();
            lightingSystem.TurnOff();
            Console.WriteLine("Конец фильма ");
        }
    }

    class Program
    {
        static void Main(string[] args) 
        { 
            AudioSystem audioSystem = new AudioSystem();
            VideoProjector videoProjector = new VideoProjector();
            LightingSystem lightingSystem = new LightingSystem();

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(audioSystem, videoProjector, lightingSystem);
            homeTheater.StartMove();

            Console.WriteLine();
            homeTheater.EndMove();

            Console.ReadKey();
        }
    }
}
