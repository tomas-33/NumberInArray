using Lib;

namespace Tests
{
    public class AnswerTests
    {
        private readonly int[] _ints;
        private readonly int _k;
        private readonly int _v;

        public AnswerTests()
        {
            var rand = new Random();
            _ints = new int[100000];

            for (int i = 0; i < 100000; i++)
            {
                _ints[i] = i * 10;
            }

            _k = 345430;
            _v = 345435;
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ExistsNet_True()
        {
            var anser = Answer.ExistsListAny(_ints, _k);

            Assert.That(anser, Is.True);
            Assert.Pass();
        }

        [Test]
        public void ExistsBuiltInBinarySearch_True()
        {
            var anser = Answer.ExistsBuiltInBinarySearch(_ints, _k);

            Assert.That(anser, Is.True);
            Assert.Pass();
        }

        [Test]
        public void Exists_True()
        {
            var anser = Answer.Exists(_ints, _k);

            Assert.That(anser, Is.True);
            Assert.Pass();
        }

        [Test]
        public void ExistsBinarySearchChatGpt_True()
        {
            var anser = Answer.ExistsBinarySearchChatGpt(_ints, _k);

            Assert.That(anser, Is.True);
            Assert.Pass();
        }

        [Test]
        public void ExistsBubble_True()
        {
            var anser = Answer.ExistsBubble(_ints, _k);

            Assert.That(anser, Is.True);
            Assert.Pass();
        }

        [Test]
        public void ExistsNet_False()
        {
            var anser = Answer.ExistsListAny(_ints, _v);

            Assert.That(anser, Is.False);
            Assert.Pass();
        }

        [Test]
        public void ExistsBuiltInBinarySearch_False()
        {
            var anser = Answer.ExistsBuiltInBinarySearch(_ints, _v);

            Assert.That(anser, Is.False);
            Assert.Pass();
        }

        [Test]
        public void Exists_False()
        {
            var anser = Answer.Exists(_ints, _v);

            Assert.That(anser, Is.False);
            Assert.Pass();
        }

        [Test]
        public void ExistsBinarySearchChatGpt_False()
        {
            var anser = Answer.ExistsBinarySearchChatGpt(_ints, _v);

            Assert.That(anser, Is.False);
            Assert.Pass();
        }

        [Test]
        public void ExistsBubble_False()
        {
            var anser = Answer.ExistsBubble(_ints, _v);

            Assert.That(anser, Is.False);
            Assert.Pass();
        }

        [Test]
        public void Exists_EvenFalse()
        {
            var ints = new int[19];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = i * 2;
            }

            var anser = Answer.Exists(ints, 5);

            Assert.That(anser, Is.False);
            Assert.Pass();
        }
    }
}