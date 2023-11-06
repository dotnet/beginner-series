# Convert analog signals to digital data with .NET

How do analog signals get converted into digital data? In this episode of .NET IoT for Beginners, Microsoft Sr. Content Developer Cam Soper explores Analog-to-Digital converters (ADCs) with single-board computers and the .NET IoT libraries. Cam then shows how he uses a Raspberry Pi and an MCP3008 ADC for one of his favorite activities: BBQ with .NET!

## A note about the RTD circuit in the video

I'm not an electrical engineer. 

When I was compiling these notes, I couldn't find much information to refresh my memory on how I designed my RTD circuit. Most RTD circuits seem to be a little more complicated than the solution I presented, which is basically a [voltage divider](https://en.wikipedia.org/wiki/Voltage_divider) with a variable resistor on one end (the RTD). I seem to think my research a few years ago when I built my PID controller indicated that this was called a voltage drop circuit, but looking back now, I'm not sure that's what it's called. My apologies if I was wrong in the video. If you're an electrical engineer, please [reach out to educate me](mailto:Cam.Soper@microsoft.com). 🙂

In conclusion, don't take my word on it that the circuit in the video is the correct way to read an RTD. It works fine for the purposes of my smoker (I've tested the accuracy) but I don't have much confidence that my way is the best way or even technically correct. You might be better advised to use an RTD-specific ADC like the MAX31865.

## Code

- [Read values from an analog-to-digital converter](https://github.com/MicrosoftDocs/dotnet-iot-assets/tree/main/tutorials/SensorTutorial) (source)
- [Ads1115 example](./code/Adc)
- [RTD probe example](./code/temperature)

## Links

- [Read values from an analog-to-digital converter](https://learn.microsoft.com/dotnet/iot/tutorials/adc) (tutorial)
- [Iot.Device.Adc.Mcp3008 Class](https://learn.microsoft.com/dotnet/api/iot.device.adc.mcp3008?view=iot-dotnet-latest)
- [Iot.Device.Ads1115.Ads1115 Class](https://learn.microsoft.com/dotnet/api/iot.device.ads1115.ads1115?view=iot-dotnet-latest)
- [Iot.Device.Max31865.Max31865 Class](https://learn.microsoft.com/dotnet/api/iot.device.max31865.max31865?view=iot-dotnet-latest)
- [Cam Soper's Inferno smoker project](https://github.com/CamSoper/Inferno)
- [Home Assistant](https://www.home-assistant.io)
- [MQTTnet](https://github.com/dotnet/MQTTnet)
- [.NET IoT Libraries documentation](https://learn.microsoft.com/dotnet/iot/)
- [.NET Docs GitHub repo](https://github.com/dotnet/docs)
