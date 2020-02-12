using EnvironmentBusinessLayer;
using ModulesFeature;
using NUnit.Framework;

namespace UnitTests
{
    public class ConsoleOutputTests {
        [Test]
        public void FormatLine_UsesEnvironmentSuffix()
        {
            IOutput m_sut = new ConsoleOutput(new TestEnvironment());

            string formattedLine = m_sut.FormatLine( "test line" );

            Assert.That( formattedLine, Is.EqualTo( "Test PC > test line" ) );
        }

        private sealed class TestEnvironment : IEnvironment {

            string IEnvironment.MachineName() {
                return "Test PC";
            }

        }
    }
}