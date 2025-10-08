

// See https://aka.ms/new-console-template for more information
using OOPSep25Week4;

// Application Code / Client Code

Console.WriteLine("Hello, World!");

SensorData sensorData = new SensorData();
//sensorData.readData();

SensorReading sensorReading = new SensorReading();

SensorReading sensorReading2 = new SensorReading(30, 67);
Console.WriteLine("Val is "+sensorReading2.GetVal());