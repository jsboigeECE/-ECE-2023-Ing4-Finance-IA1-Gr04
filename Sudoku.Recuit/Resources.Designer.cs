﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sudoku.Recuit {
    using System;
    
    
    /// <summary>
    ///   Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    /// </summary>
    // Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    // à l'aide d'un outil, tel que ResGen ou Visual Studio.
    // Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    // avec l'option /str ou régénérez votre projet VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Sudoku.Recuit.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Remplace la propriété CurrentUICulture du thread actuel pour toutes
        ///   les recherches de ressources à l'aide de cette classe de ressource fortement typée.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à import ctypes
        ///
        ///import numpy as np
        ///
        ///import clr 
        ///import System
        ///from System import Array, Int32
        ///from System.Runtime.InteropServices import GCHandle, GCHandleType
        ///
        ///_MAP_NP_NET = {
        ///    np.dtype(np.float32): System.Single,
        ///    np.dtype(np.float64): System.Double,
        ///    np.dtype(np.int8)   : System.SByte,
        ///    np.dtype(np.int16)  : System.Int16,
        ///    np.dtype(np.int32)  : System.Int32,
        ///    np.dtype(np.int64)  : System.Int64,
        ///    np.dtype(np.uint8)  : System.Byte,
        ///    np.dtype(np.uint16) : System.UInt1 [le reste de la chaîne a été tronqué]&quot;;.
        /// </summary>
        internal static string numpy_converter {
            get {
                return ResourceManager.GetString("numpy_converter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à import copy
        ///import random
        ///import numpy as np
        ///from simanneal import Annealer
        ///
        ///sudoku = np.asarray(instance)
        ///
        ///# from https://neos-guide.org/content/sudoku
        ///
        ///
        ///PROBLEM = sudoku.reshape(81,)
        ///
        ///def print_sudoku(state):
        ///    border = &quot;------+-------+------&quot;
        ///    rows = [state[i:i+9] for i in range(0,81,9)]
        ///    for i,row in enumerate(rows):
        ///        if i % 3 == 0:
        ///            print(border)
        ///        three = [row[i:i+3] for i in range(0,9,3)]
        ///        print(&quot; | &quot;.join(
        ///            &quot; &quot;.join(str(x or &quot;_&quot;)  [le reste de la chaîne a été tronqué]&quot;;.
        /// </summary>
        internal static string RecuitSimaneal {
            get {
                return ResourceManager.GetString("RecuitSimaneal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à import random
        ///import numpy as np
        ///import math 
        ///from random import choice
        ///import statistics 
        ///
        ///import clr 
        ///clr.AddReference(&quot;Sudoku.Shared&quot;) 
        ///
        ///sudoku = np.array([[int(i) for i in line] for line in sudoku])
        ///
        ///def FixSudokuValues(fixed_sudoku):
        ///    for i in range (0,9):
        ///        for j in range (0,9):
        ///            if fixed_sudoku[i,j] != 0:
        ///                fixed_sudoku[i,j] = 1
        ///    
        ///    return(fixed_sudoku)
        ///
        ///# Cost Function    
        ///def CalculateNumberOfErrors(sudoku):
        ///    numberOfErrors = 0 
        ///    fo [le reste de la chaîne a été tronqué]&quot;;.
        /// </summary>
        internal static string sudoku {
            get {
                return ResourceManager.GetString("sudoku", resourceCulture);
            }
        }
    }
}