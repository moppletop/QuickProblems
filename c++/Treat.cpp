#include "stdafx.h"

class Treat {

public:
	static bool isTreatday(bool weekend, bool holiday)
	{
		return weekend || holiday;
	}

};