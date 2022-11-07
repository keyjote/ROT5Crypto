using System.Diagnostics;
using ROT5Crypto;

namespace Test;

public class SpeedTest
{
    [Fact]
    public async void SpeedyGonzales()
    {
        var path = Path.Combine(Environment.CurrentDirectory, @"Data\words_alpha.txt");
        await using var fs = File.OpenRead(path);
        using var sr = new StreamReader(fs);

        var sw = Stopwatch.StartNew();

        var counter = 0;
        while (await sr.ReadLineAsync() is { } line)
        {
            var result = string.Empty;
            foreach (var leChar in line.ToCharArray())
            {
                result += Rot13.CryptMe(Rot13.CryptMe(leChar));
            }
            
            Assert.Equal(line, result);
            counter++;
        }
        sw.Stop();
        
        Assert.Equal(370105, counter);
        Assert.True(sw.Elapsed.TotalSeconds < 1);
    }
}