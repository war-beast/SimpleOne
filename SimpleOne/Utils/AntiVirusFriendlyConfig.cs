using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Toolchains.InProcess.Emit;
using BenchmarkDotNet.Toolchains.InProcess.NoEmit;

namespace SimpleOne.Utils;

public class AntiVirusFriendlyConfig : ManualConfig
{
	public AntiVirusFriendlyConfig()
	{
		AddJob(Job.MediumRun
			.WithLaunchCount(1)
			.WithToolchain(InProcessEmitToolchain.Instance));
	}
}