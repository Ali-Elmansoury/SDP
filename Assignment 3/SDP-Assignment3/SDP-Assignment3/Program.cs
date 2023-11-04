// See https://aka.ms/new-console-template for more information

using SDP_Assignment3;

string cardType;

PCP_Factory factory = new PCP_Factory();

Console.WriteLine("Available card types:\n\t1.Visa\n\t2.MasterCard\n\t3.AmericanExpress\n\t4.Discover\n\t5.DinersClub\n\t6.JCB\n\t7.UnionPay\n\t8.Maestro\n\t9.Electron\n\t10.Meeza\n");
Console.WriteLine("Enter card type and please be aware of uppercase:");
cardType = Console.ReadLine();

I_PaymentCardProcessor pcp = factory.getData(cardType);
Console.Write("\n");
pcp.identifier();
pcp.usedByBank();
