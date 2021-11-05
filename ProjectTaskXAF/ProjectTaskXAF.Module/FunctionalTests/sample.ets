;#DropDB ProjectTaskXAFEasyTest

#Application ProjectTaskXAFWin
#Application ProjectTaskXAFWeb

*FillForm
 User Name = Admin
*Action Log In

#IfDef ProjectTaskXAFWin

*Action About...
 
*Action OK

#EndIf

#IfDef ProjectTaskXAFWeb
*Action Navigation(My Details)
#EndIf
