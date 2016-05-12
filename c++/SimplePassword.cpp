#include "stdafx.h"
#include <iostream>
#include <string>

using namespace std;

class SimplePassword {

public:
	static void password()
	{
		cout << "What is the password?" << endl;

		string password;
		getline(cin, password);

		if (password.compare("myPassword")) {
			cout << "The password is correct" << endl;
		} else {
			cout << "The password is incorrect" << endl;
		}
	};
};