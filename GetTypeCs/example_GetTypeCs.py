# -*- coding: utf-8 -*-

"""
Check IronPython's class with C # GetType.

* Run this file.
"""

import clr
clr.AddReferenceToFile("../x64/Release/GetTypeCs.dll")
from MyUtil import MyFunction as Func

var01 = 1
print(Func.GetTypeCs(var01))

var02 = 1L
print(Func.GetTypeCs(var02))

var03 = float(1)
print(Func.GetTypeCs(var03))

var04 = [1L, 2L, 3L]
print(Func.GetTypeCs_IList(var04))

help(Func.GetTypeCs)