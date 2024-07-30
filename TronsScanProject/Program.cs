// See https://aka.ms/new-console-template for more information
using TronsScanProject;

var reqvest = await new  TronsScanWork( new SettingsTronsScanDefault() { Hash = "853793d552635f533aa982b92b35b00e63a1c1add062c099da2450a15119bcb2" }).GetResponse();
Console.WriteLine(reqvest.noteLevel);
 