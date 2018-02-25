// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, QUT 2005-2010
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.3.6
// Machine:  LENOVO-PC
// DateTime: 25.02.2018 12:15:59
// UserName: ??????
// Input file <SimpleYacc.y>

// options: no-lines gplex

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using QUT.Gppg;
using Compiler.Parser.AST;

namespace Compiler.Parser
{
public enum Tokens {
    error=1,EOF=2,BEGIN=3,END=4,CYCLE=5,ASSIGN=6,
    SEMICOLON=7,OPENBR=8,CLOSEBR=9,COMMA=10,PRINT=11,FOR=12,
    PLUS=13,MINUS=14,MULT=15,DIV=16,IF=17,ELSE=18,
    GT=19,LT=20,GE=21,LE=22,EQ=23,NEQ=24,
    NOT=25,GOTO=26,COLON=27,INUM=28,ID=29};

public struct ValueType
{ 
	public int iVal; 
	public string sVal; 
	public Node nVal;
	public ExprNode eVal;
	public StatementNode stVal;
	public BlockNode blVal;
	public PrintNode prVal;
	public ExprListNode elVal;
	public GoToNode gtNode;
	public LabelNode lbNode;
       }
// Abstract base class for GPLEX scanners
public abstract class ScanBase : AbstractScanner<ValueType,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

public class Parser: ShiftReduceParser<ValueType, LexLocation>
{
  // Verbatim content from SimpleYacc.y
    public BlockNode root; 
    public Parser(AbstractScanner<ValueType, LexLocation> scanner) : base(scanner) { }
  // End verbatim content from SimpleYacc.y

#pragma warning disable 649
  private static Dictionary<int, string> aliasses;
#pragma warning restore 649
  private static Rule[] rules = new Rule[47];
  private static State[] states = new State[98];
  private static string[] nonTerms = new string[] {
      "expr", "ident", "W", "T", "F", "assign", "statement", "cycle", "for", 
      "if", "stlist", "block", "print", "exprlist", "progr", "$accept", };

  static Parser() {
    states[0] = new State(new int[]{29,8,26,9,5,15,12,24,11,81,17,89,3,20,2,-13},new int[]{-15,1,-11,3,-7,97,-2,5,-6,12,-8,14,-9,23,-13,79,-10,88,-12,96});
    states[1] = new State(new int[]{2,2});
    states[2] = new State(-1);
    states[3] = new State(new int[]{29,8,26,9,5,15,12,24,11,81,17,89,3,20,2,-2},new int[]{-7,4,-2,5,-6,12,-8,14,-9,23,-13,79,-10,88,-12,96});
    states[4] = new State(-4);
    states[5] = new State(new int[]{27,6,6,77});
    states[6] = new State(new int[]{29,8,26,9,5,15,12,24,11,81,17,89,3,20,2,-13,4,-13},new int[]{-7,7,-2,5,-6,12,-8,14,-9,23,-13,79,-10,88,-12,96});
    states[7] = new State(-5);
    states[8] = new State(-14);
    states[9] = new State(new int[]{29,8},new int[]{-2,10});
    states[10] = new State(new int[]{7,11});
    states[11] = new State(-6);
    states[12] = new State(new int[]{7,13});
    states[13] = new State(-7);
    states[14] = new State(-8);
    states[15] = new State(new int[]{8,16});
    states[16] = new State(new int[]{14,37,25,48,29,8,28,58,8,59},new int[]{-1,17,-3,73,-4,45,-5,56,-2,57});
    states[17] = new State(new int[]{9,18,13,33,20,43,21,54,22,62,19,67,23,69,24,71,14,65});
    states[18] = new State(new int[]{3,20},new int[]{-12,19});
    states[19] = new State(-39);
    states[20] = new State(new int[]{29,8,26,9,5,15,12,24,11,81,17,89,3,20,4,-13},new int[]{-11,21,-7,97,-2,5,-6,12,-8,14,-9,23,-13,79,-10,88,-12,96});
    states[21] = new State(new int[]{4,22,29,8,26,9,5,15,12,24,11,81,17,89,3,20},new int[]{-7,4,-2,5,-6,12,-8,14,-9,23,-13,79,-10,88,-12,96});
    states[22] = new State(-38);
    states[23] = new State(-9);
    states[24] = new State(new int[]{8,25});
    states[25] = new State(new int[]{29,8},new int[]{-6,26,-2,76});
    states[26] = new State(new int[]{10,27});
    states[27] = new State(new int[]{14,37,25,48,29,8,28,58,8,59},new int[]{-1,28,-3,73,-4,45,-5,56,-2,57});
    states[28] = new State(new int[]{10,29,9,74,13,33,20,43,21,54,22,62,19,67,23,69,24,71,14,65});
    states[29] = new State(new int[]{14,37,25,48,29,8,28,58,8,59},new int[]{-1,30,-3,73,-4,45,-5,56,-2,57});
    states[30] = new State(new int[]{9,31,13,33,20,43,21,54,22,62,19,67,23,69,24,71,14,65});
    states[31] = new State(new int[]{3,20},new int[]{-12,32});
    states[32] = new State(-40);
    states[33] = new State(new int[]{14,37,25,48,29,8,28,58,8,59},new int[]{-4,34,-5,56,-2,57});
    states[34] = new State(new int[]{15,35,16,46,9,-24,13,-24,20,-24,21,-24,22,-24,19,-24,23,-24,24,-24,14,-24,10,-24,7,-24});
    states[35] = new State(new int[]{14,37,25,48,29,8,28,58,8,59},new int[]{-5,36,-2,57});
    states[36] = new State(-27);
    states[37] = new State(new int[]{28,39,8,40,29,8},new int[]{-2,38});
    states[38] = new State(-29);
    states[39] = new State(-30);
    states[40] = new State(new int[]{14,37,25,48,29,8,28,58,8,59},new int[]{-1,41,-3,73,-4,45,-5,56,-2,57});
    states[41] = new State(new int[]{9,42,13,33,20,43,21,54,22,62,19,67,23,69,24,71,14,65});
    states[42] = new State(-36);
    states[43] = new State(new int[]{14,37,25,48,29,8,28,58,8,59},new int[]{-3,44,-4,45,-5,56,-2,57,-1,64});
    states[44] = new State(new int[]{9,-17,13,-16,20,-16,21,-16,22,-16,19,-16,23,-16,24,-16,14,-16,10,-17,7,-17});
    states[45] = new State(new int[]{15,35,16,46,9,-23,13,-23,20,-23,21,-23,22,-23,19,-23,23,-23,24,-23,14,-23,10,-23,7,-23});
    states[46] = new State(new int[]{14,37,25,48,29,8,28,58,8,59},new int[]{-5,47,-2,57});
    states[47] = new State(-28);
    states[48] = new State(new int[]{28,50,8,51,29,8},new int[]{-2,49});
    states[49] = new State(-31);
    states[50] = new State(-32);
    states[51] = new State(new int[]{14,37,25,48,29,8,28,58,8,59},new int[]{-1,52,-3,73,-4,45,-5,56,-2,57});
    states[52] = new State(new int[]{9,53,13,33,20,43,21,54,22,62,19,67,23,69,24,71,14,65});
    states[53] = new State(-37);
    states[54] = new State(new int[]{14,37,25,48,29,8,28,58,8,59},new int[]{-3,55,-4,45,-5,56,-2,57,-1,64});
    states[55] = new State(new int[]{9,-18,13,-16,20,-16,21,-16,22,-16,19,-16,23,-16,24,-16,14,-16,10,-18,7,-18});
    states[56] = new State(-26);
    states[57] = new State(-33);
    states[58] = new State(-34);
    states[59] = new State(new int[]{14,37,25,48,29,8,28,58,8,59},new int[]{-1,60,-3,73,-4,45,-5,56,-2,57});
    states[60] = new State(new int[]{9,61,13,33,20,43,21,54,22,62,19,67,23,69,24,71,14,65});
    states[61] = new State(-35);
    states[62] = new State(new int[]{14,37,25,48,29,8,28,58,8,59},new int[]{-3,63,-4,45,-5,56,-2,57,-1,64});
    states[63] = new State(new int[]{9,-19,13,-16,20,-16,21,-16,22,-16,19,-16,23,-16,24,-16,14,-16,10,-19,7,-19});
    states[64] = new State(new int[]{13,33,14,65,20,43,21,54,22,62,19,67,23,69,24,71});
    states[65] = new State(new int[]{14,37,25,48,29,8,28,58,8,59},new int[]{-4,66,-5,56,-2,57});
    states[66] = new State(new int[]{15,35,16,46,9,-25,13,-25,20,-25,21,-25,22,-25,19,-25,23,-25,24,-25,14,-25,10,-25,7,-25});
    states[67] = new State(new int[]{14,37,25,48,29,8,28,58,8,59},new int[]{-3,68,-4,45,-5,56,-2,57,-1,64});
    states[68] = new State(new int[]{9,-20,13,-16,20,-16,21,-16,22,-16,19,-16,23,-16,24,-16,14,-16,10,-20,7,-20});
    states[69] = new State(new int[]{14,37,25,48,29,8,28,58,8,59},new int[]{-3,70,-4,45,-5,56,-2,57,-1,64});
    states[70] = new State(new int[]{9,-21,13,-16,20,-16,21,-16,22,-16,19,-16,23,-16,24,-16,14,-16,10,-21,7,-21});
    states[71] = new State(new int[]{14,37,25,48,29,8,28,58,8,59},new int[]{-3,72,-4,45,-5,56,-2,57,-1,64});
    states[72] = new State(new int[]{9,-22,13,-16,20,-16,21,-16,22,-16,19,-16,23,-16,24,-16,14,-16,10,-22,7,-22});
    states[73] = new State(-16);
    states[74] = new State(new int[]{3,20},new int[]{-12,75});
    states[75] = new State(-41);
    states[76] = new State(new int[]{6,77});
    states[77] = new State(new int[]{14,37,25,48,29,8,28,58,8,59},new int[]{-1,78,-3,73,-4,45,-5,56,-2,57});
    states[78] = new State(new int[]{13,33,20,43,21,54,22,62,19,67,23,69,24,71,14,65,7,-15,10,-15});
    states[79] = new State(new int[]{7,80});
    states[80] = new State(-10);
    states[81] = new State(new int[]{8,82});
    states[82] = new State(new int[]{14,37,25,48,29,8,28,58,8,59},new int[]{-14,83,-1,87,-3,73,-4,45,-5,56,-2,57});
    states[83] = new State(new int[]{9,84,10,85});
    states[84] = new State(-44);
    states[85] = new State(new int[]{14,37,25,48,29,8,28,58,8,59},new int[]{-1,86,-3,73,-4,45,-5,56,-2,57});
    states[86] = new State(new int[]{13,33,20,43,21,54,22,62,19,67,23,69,24,71,14,65,9,-43,10,-43});
    states[87] = new State(new int[]{13,33,20,43,21,54,22,62,19,67,23,69,24,71,14,65,9,-42,10,-42});
    states[88] = new State(-11);
    states[89] = new State(new int[]{8,90});
    states[90] = new State(new int[]{14,37,25,48,29,8,28,58,8,59},new int[]{-1,91,-3,73,-4,45,-5,56,-2,57});
    states[91] = new State(new int[]{9,92,13,33,20,43,21,54,22,62,19,67,23,69,24,71,14,65});
    states[92] = new State(new int[]{3,20},new int[]{-12,93});
    states[93] = new State(new int[]{18,94,29,-46,26,-46,5,-46,12,-46,11,-46,17,-46,3,-46,2,-46,4,-46});
    states[94] = new State(new int[]{3,20},new int[]{-12,95});
    states[95] = new State(-45);
    states[96] = new State(-12);
    states[97] = new State(-3);

    rules[1] = new Rule(-16, new int[]{-15,2});
    rules[2] = new Rule(-15, new int[]{-11});
    rules[3] = new Rule(-11, new int[]{-7});
    rules[4] = new Rule(-11, new int[]{-11,-7});
    rules[5] = new Rule(-7, new int[]{-2,27,-7});
    rules[6] = new Rule(-7, new int[]{26,-2,7});
    rules[7] = new Rule(-7, new int[]{-6,7});
    rules[8] = new Rule(-7, new int[]{-8});
    rules[9] = new Rule(-7, new int[]{-9});
    rules[10] = new Rule(-7, new int[]{-13,7});
    rules[11] = new Rule(-7, new int[]{-10});
    rules[12] = new Rule(-7, new int[]{-12});
    rules[13] = new Rule(-7, new int[]{});
    rules[14] = new Rule(-2, new int[]{29});
    rules[15] = new Rule(-6, new int[]{-2,6,-1});
    rules[16] = new Rule(-1, new int[]{-3});
    rules[17] = new Rule(-1, new int[]{-1,20,-3});
    rules[18] = new Rule(-1, new int[]{-1,21,-3});
    rules[19] = new Rule(-1, new int[]{-1,22,-3});
    rules[20] = new Rule(-1, new int[]{-1,19,-3});
    rules[21] = new Rule(-1, new int[]{-1,23,-3});
    rules[22] = new Rule(-1, new int[]{-1,24,-3});
    rules[23] = new Rule(-3, new int[]{-4});
    rules[24] = new Rule(-3, new int[]{-1,13,-4});
    rules[25] = new Rule(-3, new int[]{-1,14,-4});
    rules[26] = new Rule(-4, new int[]{-5});
    rules[27] = new Rule(-4, new int[]{-4,15,-5});
    rules[28] = new Rule(-4, new int[]{-4,16,-5});
    rules[29] = new Rule(-5, new int[]{14,-2});
    rules[30] = new Rule(-5, new int[]{14,28});
    rules[31] = new Rule(-5, new int[]{25,-2});
    rules[32] = new Rule(-5, new int[]{25,28});
    rules[33] = new Rule(-5, new int[]{-2});
    rules[34] = new Rule(-5, new int[]{28});
    rules[35] = new Rule(-5, new int[]{8,-1,9});
    rules[36] = new Rule(-5, new int[]{14,8,-1,9});
    rules[37] = new Rule(-5, new int[]{25,8,-1,9});
    rules[38] = new Rule(-12, new int[]{3,-11,4});
    rules[39] = new Rule(-8, new int[]{5,8,-1,9,-12});
    rules[40] = new Rule(-9, new int[]{12,8,-6,10,-1,10,-1,9,-12});
    rules[41] = new Rule(-9, new int[]{12,8,-6,10,-1,9,-12});
    rules[42] = new Rule(-14, new int[]{-1});
    rules[43] = new Rule(-14, new int[]{-14,10,-1});
    rules[44] = new Rule(-13, new int[]{11,8,-14,9});
    rules[45] = new Rule(-10, new int[]{17,8,-1,9,-12,18,-12});
    rules[46] = new Rule(-10, new int[]{17,8,-1,9,-12});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Tokens.error, (int)Tokens.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
    switch (action)
    {
      case 2: // progr -> stlist
{ root = ValueStack[ValueStack.Depth-1].blVal; }
        break;
      case 3: // stlist -> statement
{ 
				CurrentSemanticValue.blVal = new BlockNode(ValueStack[ValueStack.Depth-1].stVal); 
			}
        break;
      case 4: // stlist -> stlist, statement
{ 
				ValueStack[ValueStack.Depth-2].blVal.Add(ValueStack[ValueStack.Depth-1].stVal); 
				CurrentSemanticValue.blVal = ValueStack[ValueStack.Depth-2].blVal; 
			}
        break;
      case 5: // statement -> ident, COLON, statement
{ CurrentSemanticValue.stVal = new LabelNode(ValueStack[ValueStack.Depth-3].eVal as IdNode, ValueStack[ValueStack.Depth-1].stVal); }
        break;
      case 6: // statement -> GOTO, ident, SEMICOLON
{ CurrentSemanticValue.stVal = new GoToNode(ValueStack[ValueStack.Depth-2].eVal as IdNode); }
        break;
      case 7: // statement -> assign, SEMICOLON
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-2].stVal; }
        break;
      case 8: // statement -> cycle
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 9: // statement -> for
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 10: // statement -> print, SEMICOLON
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-2].prVal; }
        break;
      case 11: // statement -> if
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].stVal; }
        break;
      case 12: // statement -> block
{ CurrentSemanticValue.stVal = ValueStack[ValueStack.Depth-1].blVal; }
        break;
      case 13: // statement -> /* empty */
{ CurrentSemanticValue.stVal = new EmptyNode(); }
        break;
      case 14: // ident -> ID
{ CurrentSemanticValue.eVal = new IdNode(ValueStack[ValueStack.Depth-1].sVal); }
        break;
      case 15: // assign -> ident, ASSIGN, expr
{ CurrentSemanticValue.stVal = new AssignNode(ValueStack[ValueStack.Depth-3].eVal as IdNode, ValueStack[ValueStack.Depth-1].eVal); }
        break;
      case 16: // expr -> W
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 17: // expr -> expr, LT, W
{ CurrentSemanticValue.eVal = new BinaryNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, "<"); }
        break;
      case 18: // expr -> expr, GE, W
{ CurrentSemanticValue.eVal = new BinaryNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, ">"); }
        break;
      case 19: // expr -> expr, LE, W
{ CurrentSemanticValue.eVal = new BinaryNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, "<="); }
        break;
      case 20: // expr -> expr, GT, W
{ CurrentSemanticValue.eVal = new BinaryNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, ">="); }
        break;
      case 21: // expr -> expr, EQ, W
{ CurrentSemanticValue.eVal = new BinaryNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, "=="); }
        break;
      case 22: // expr -> expr, NEQ, W
{ CurrentSemanticValue.eVal = new BinaryNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, "!="); }
        break;
      case 23: // W -> T
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 24: // W -> expr, PLUS, T
{ CurrentSemanticValue.eVal = new BinaryNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, "+"); }
        break;
      case 25: // W -> expr, MINUS, T
{ CurrentSemanticValue.eVal = new BinaryNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, "-"); }
        break;
      case 26: // T -> F
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal; }
        break;
      case 27: // T -> T, MULT, F
{ CurrentSemanticValue.eVal = new BinaryNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, "*"); }
        break;
      case 28: // T -> T, DIV, F
{ CurrentSemanticValue.eVal = new BinaryNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].eVal, "/"); }
        break;
      case 29: // F -> MINUS, ident
{ CurrentSemanticValue.eVal = new UnaryNode(ValueStack[ValueStack.Depth-1].eVal, '-');}
        break;
      case 30: // F -> MINUS, INUM
{ CurrentSemanticValue.eVal = new UnaryNode(ValueStack[ValueStack.Depth-1].iVal, '-');}
        break;
      case 31: // F -> NOT, ident
{ CurrentSemanticValue.eVal = new UnaryNode(ValueStack[ValueStack.Depth-1].eVal, '!');}
        break;
      case 32: // F -> NOT, INUM
{ CurrentSemanticValue.eVal = new UnaryNode(ValueStack[ValueStack.Depth-1].iVal, '!');}
        break;
      case 33: // F -> ident
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-1].eVal as IdNode; }
        break;
      case 34: // F -> INUM
{ CurrentSemanticValue.eVal = new IntNumNode(ValueStack[ValueStack.Depth-1].iVal); }
        break;
      case 35: // F -> OPENBR, expr, CLOSEBR
{ CurrentSemanticValue.eVal = ValueStack[ValueStack.Depth-2].eVal; }
        break;
      case 36: // F -> MINUS, OPENBR, expr, CLOSEBR
{ CurrentSemanticValue.eVal = new UnaryNode(ValueStack[ValueStack.Depth-2].eVal, '-');}
        break;
      case 37: // F -> NOT, OPENBR, expr, CLOSEBR
{ CurrentSemanticValue.eVal = new UnaryNode(ValueStack[ValueStack.Depth-2].eVal, '!');}
        break;
      case 38: // block -> BEGIN, stlist, END
{ CurrentSemanticValue.blVal = ValueStack[ValueStack.Depth-2].blVal; }
        break;
      case 39: // cycle -> CYCLE, OPENBR, expr, CLOSEBR, block
{ CurrentSemanticValue.stVal = new CycleNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].blVal); }
        break;
      case 40: // for -> FOR, OPENBR, assign, COMMA, expr, COMMA, expr, CLOSEBR, block
{ CurrentSemanticValue.stVal = new ForNode(ValueStack[ValueStack.Depth-7].stVal as AssignNode, ValueStack[ValueStack.Depth-5].eVal, ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].blVal); }
        break;
      case 41: // for -> FOR, OPENBR, assign, COMMA, expr, CLOSEBR, block
{ CurrentSemanticValue.stVal = new ForNode(ValueStack[ValueStack.Depth-5].stVal as AssignNode, ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].blVal); }
        break;
      case 42: // exprlist -> expr
{ 
				CurrentSemanticValue.elVal = new ExprListNode(ValueStack[ValueStack.Depth-1].eVal); 
			}
        break;
      case 43: // exprlist -> exprlist, COMMA, expr
{ 
				ValueStack[ValueStack.Depth-3].elVal.Add(ValueStack[ValueStack.Depth-1].eVal); 
				CurrentSemanticValue.elVal = ValueStack[ValueStack.Depth-3].elVal; 
			}
        break;
      case 44: // print -> PRINT, OPENBR, exprlist, CLOSEBR
{ CurrentSemanticValue.prVal = new PrintNode(ValueStack[ValueStack.Depth-2].elVal); }
        break;
      case 45: // if -> IF, OPENBR, expr, CLOSEBR, block, ELSE, block
{ CurrentSemanticValue.stVal = new IfNode(ValueStack[ValueStack.Depth-5].eVal, ValueStack[ValueStack.Depth-3].blVal, ValueStack[ValueStack.Depth-1].blVal); }
        break;
      case 46: // if -> IF, OPENBR, expr, CLOSEBR, block
{ CurrentSemanticValue.stVal = new IfNode(ValueStack[ValueStack.Depth-3].eVal, ValueStack[ValueStack.Depth-1].blVal); }
        break;
    }
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliasses != null && aliasses.ContainsKey(terminal))
        return aliasses[terminal];
    else if (((Tokens)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Tokens)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

}
}
