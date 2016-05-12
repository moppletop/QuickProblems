#include "stdafx.h"
#include <iostream>
#include <string>

using namespace std;

class HelloX {

public:
	static void helloX()
	{
		cout << "What is your name?" << endl;

		string name;
		getline(cin, name);

		cout << "Hello " << name << endl;
	};
};