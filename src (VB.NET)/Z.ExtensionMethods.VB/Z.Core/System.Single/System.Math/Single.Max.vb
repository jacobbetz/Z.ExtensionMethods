
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_473

	''' <summary>
	'''     Returns the larger of two single-precision floating-point numbers.
	''' </summary>
	''' <param name="val1">The first of two single-precision floating-point numbers to compare.</param>
	''' <param name="val2">The second of two single-precision floating-point numbers to compare.</param>
	''' <returns>Parameter  or , whichever is larger. If , or , or both  and  are equal to ,  is returned.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Max(val1 As [Single], val2 As [Single]) As [Single]
		Return Math.Max(val1, val2)
	End Function
End Module


