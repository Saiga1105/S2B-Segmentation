/*
* MATLAB Compiler: 6.6 (R2018a)
* Date: Fri Jul 19 12:45:33 2019
* Arguments:
* "-B""macro_default""-W""dotnet:Segmentation,segment,4.0,private""-T""link:lib""-d""D:\Sc
* an-to-BIM repository\Segmentation\bin\for_testing""-v""class{segment:D:\Scan-to-BIM
* repository\Segmentation\Source\G_mesh_segmentation_test1.m,D:\Scan-to-BIM
* repository\Segmentation\Source\G_RegionGrowingNC1.m,D:\Scan-to-BIM
* repository\Segmentation\Source\G_RegionGrowingNC2.m,D:\Scan-to-BIM
* repository\Segmentation\Source\G_Resolution_PCD.m}"
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace Segmentation
{

  /// <summary>
  /// The segment class provides a CLS compliant, MWArray interface to the MATLAB
  /// functions contained in the files:
  /// <newpara></newpara>
  /// D:\Scan-to-BIM repository\Segmentation\Source\G_mesh_segmentation_test1.m
  /// <newpara></newpara>
  /// D:\Scan-to-BIM repository\Segmentation\Source\G_RegionGrowingNC1.m
  /// <newpara></newpara>
  /// D:\Scan-to-BIM repository\Segmentation\Source\G_RegionGrowingNC2.m
  /// <newpara></newpara>
  /// D:\Scan-to-BIM repository\Segmentation\Source\G_Resolution_PCD.m
  /// </summary>
  /// <remarks>
  /// @Version 4.0
  /// </remarks>
  public class segment : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Runtime instance.
    /// </summary>
    static segment()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "Segmentation.ctf";

          Stream embeddedCtfStream = null;

          String[] resourceStrings = assembly.GetManifestResourceNames();

          foreach (String name in resourceStrings)
          {
            if (name.Contains(ctfFileName))
            {
              embeddedCtfStream = assembly.GetManifestResourceStream(name);
              break;
            }
          }
          mcr= new MWMCR("",
                         ctfFilePath, embeddedCtfStream, true);
        }
        catch(Exception ex)
        {
          ex_ = new Exception("MWArray assembly failed to be initialized", ex);
        }
      }
      else
      {
        ex_ = new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the segment class.
    /// </summary>
    public segment()
    {
      if(ex_ != null)
      {
        throw ex_;
      }
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~segment()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the
    /// G_mesh_segmentation_test1 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// F_MESH_SEGMENTATION1 Summary of this function goes here
    /// Detailed explanation goes here
    /// #function TreeBagger classificationEnsemble ClassificationECOC
    /// ClassificationBaggedEnsemble predict
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray G_mesh_segmentation_test1()
    {
      return mcr.EvaluateFunction("G_mesh_segmentation_test1", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the
    /// G_mesh_segmentation_test1 MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// F_MESH_SEGMENTATION1 Summary of this function goes here
    /// Detailed explanation goes here
    /// #function TreeBagger classificationEnsemble ClassificationECOC
    /// ClassificationBaggedEnsemble predict
    /// </remarks>
    /// <param name="points">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray G_mesh_segmentation_test1(MWArray points)
    {
      return mcr.EvaluateFunction("G_mesh_segmentation_test1", points);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the G_mesh_segmentation_test1
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// F_MESH_SEGMENTATION1 Summary of this function goes here
    /// Detailed explanation goes here
    /// #function TreeBagger classificationEnsemble ClassificationECOC
    /// ClassificationBaggedEnsemble predict
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] G_mesh_segmentation_test1(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_mesh_segmentation_test1", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the G_mesh_segmentation_test1
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// F_MESH_SEGMENTATION1 Summary of this function goes here
    /// Detailed explanation goes here
    /// #function TreeBagger classificationEnsemble ClassificationECOC
    /// ClassificationBaggedEnsemble predict
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="points">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] G_mesh_segmentation_test1(int numArgsOut, MWArray points)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_mesh_segmentation_test1", points);
    }


    /// <summary>
    /// Provides an interface for the G_mesh_segmentation_test1 function in which the
    /// input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// F_MESH_SEGMENTATION1 Summary of this function goes here
    /// Detailed explanation goes here
    /// #function TreeBagger classificationEnsemble ClassificationECOC
    /// ClassificationBaggedEnsemble predict
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void G_mesh_segmentation_test1(int numArgsOut, ref MWArray[] argsOut, 
                                MWArray[] argsIn)
    {
      mcr.EvaluateFunction("G_mesh_segmentation_test1", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the G_RegionGrowingNC1
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray G_RegionGrowingNC1()
    {
      return mcr.EvaluateFunction("G_RegionGrowingNC1", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the G_RegionGrowingNC1
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="points">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray G_RegionGrowingNC1(MWArray points)
    {
      return mcr.EvaluateFunction("G_RegionGrowingNC1", points);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the G_RegionGrowingNC1
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="points">Input argument #1</param>
    /// <param name="ThresValN">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray G_RegionGrowingNC1(MWArray points, MWArray ThresValN)
    {
      return mcr.EvaluateFunction("G_RegionGrowingNC1", points, ThresValN);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the G_RegionGrowingNC1
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="points">Input argument #1</param>
    /// <param name="ThresValN">Input argument #2</param>
    /// <param name="ThresValC">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray G_RegionGrowingNC1(MWArray points, MWArray ThresValN, MWArray 
                                ThresValC)
    {
      return mcr.EvaluateFunction("G_RegionGrowingNC1", points, ThresValN, ThresValC);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the G_RegionGrowingNC1
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="points">Input argument #1</param>
    /// <param name="ThresValN">Input argument #2</param>
    /// <param name="ThresValC">Input argument #3</param>
    /// <param name="MaxDist">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray G_RegionGrowingNC1(MWArray points, MWArray ThresValN, MWArray 
                                ThresValC, MWArray MaxDist)
    {
      return mcr.EvaluateFunction("G_RegionGrowingNC1", points, ThresValN, ThresValC, MaxDist);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the G_RegionGrowingNC1
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="points">Input argument #1</param>
    /// <param name="ThresValN">Input argument #2</param>
    /// <param name="ThresValC">Input argument #3</param>
    /// <param name="MaxDist">Input argument #4</param>
    /// <param name="Minsize">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray G_RegionGrowingNC1(MWArray points, MWArray ThresValN, MWArray 
                                ThresValC, MWArray MaxDist, MWArray Minsize)
    {
      return mcr.EvaluateFunction("G_RegionGrowingNC1", points, ThresValN, ThresValC, MaxDist, Minsize);
    }


    /// <summary>
    /// Provides a single output, 6-input MWArrayinterface to the G_RegionGrowingNC1
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="points">Input argument #1</param>
    /// <param name="ThresValN">Input argument #2</param>
    /// <param name="ThresValC">Input argument #3</param>
    /// <param name="MaxDist">Input argument #4</param>
    /// <param name="Minsize">Input argument #5</param>
    /// <param name="Offset">Input argument #6</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray G_RegionGrowingNC1(MWArray points, MWArray ThresValN, MWArray 
                                ThresValC, MWArray MaxDist, MWArray Minsize, MWArray 
                                Offset)
    {
      return mcr.EvaluateFunction("G_RegionGrowingNC1", points, ThresValN, ThresValC, MaxDist, Minsize, Offset);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the G_RegionGrowingNC1 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] G_RegionGrowingNC1(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_RegionGrowingNC1", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the G_RegionGrowingNC1 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="points">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] G_RegionGrowingNC1(int numArgsOut, MWArray points)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_RegionGrowingNC1", points);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the G_RegionGrowingNC1 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="points">Input argument #1</param>
    /// <param name="ThresValN">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] G_RegionGrowingNC1(int numArgsOut, MWArray points, MWArray ThresValN)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_RegionGrowingNC1", points, ThresValN);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the G_RegionGrowingNC1 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="points">Input argument #1</param>
    /// <param name="ThresValN">Input argument #2</param>
    /// <param name="ThresValC">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] G_RegionGrowingNC1(int numArgsOut, MWArray points, MWArray 
                                  ThresValN, MWArray ThresValC)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_RegionGrowingNC1", points, ThresValN, ThresValC);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the G_RegionGrowingNC1 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="points">Input argument #1</param>
    /// <param name="ThresValN">Input argument #2</param>
    /// <param name="ThresValC">Input argument #3</param>
    /// <param name="MaxDist">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] G_RegionGrowingNC1(int numArgsOut, MWArray points, MWArray 
                                  ThresValN, MWArray ThresValC, MWArray MaxDist)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_RegionGrowingNC1", points, ThresValN, ThresValC, MaxDist);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the G_RegionGrowingNC1 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="points">Input argument #1</param>
    /// <param name="ThresValN">Input argument #2</param>
    /// <param name="ThresValC">Input argument #3</param>
    /// <param name="MaxDist">Input argument #4</param>
    /// <param name="Minsize">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] G_RegionGrowingNC1(int numArgsOut, MWArray points, MWArray 
                                  ThresValN, MWArray ThresValC, MWArray MaxDist, MWArray 
                                  Minsize)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_RegionGrowingNC1", points, ThresValN, ThresValC, MaxDist, Minsize);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the G_RegionGrowingNC1 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="points">Input argument #1</param>
    /// <param name="ThresValN">Input argument #2</param>
    /// <param name="ThresValC">Input argument #3</param>
    /// <param name="MaxDist">Input argument #4</param>
    /// <param name="Minsize">Input argument #5</param>
    /// <param name="Offset">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] G_RegionGrowingNC1(int numArgsOut, MWArray points, MWArray 
                                  ThresValN, MWArray ThresValC, MWArray MaxDist, MWArray 
                                  Minsize, MWArray Offset)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_RegionGrowingNC1", points, ThresValN, ThresValC, MaxDist, Minsize, Offset);
    }


    /// <summary>
    /// Provides an interface for the G_RegionGrowingNC1 function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void G_RegionGrowingNC1(int numArgsOut, ref MWArray[] argsOut, MWArray[] 
                         argsIn)
    {
      mcr.EvaluateFunction("G_RegionGrowingNC1", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the G_RegionGrowingNC2
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray G_RegionGrowingNC2()
    {
      return mcr.EvaluateFunction("G_RegionGrowingNC2", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the G_RegionGrowingNC2
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="points">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray G_RegionGrowingNC2(MWArray points)
    {
      return mcr.EvaluateFunction("G_RegionGrowingNC2", points);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the G_RegionGrowingNC2
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="points">Input argument #1</param>
    /// <param name="normals">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray G_RegionGrowingNC2(MWArray points, MWArray normals)
    {
      return mcr.EvaluateFunction("G_RegionGrowingNC2", points, normals);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the G_RegionGrowingNC2
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="points">Input argument #1</param>
    /// <param name="normals">Input argument #2</param>
    /// <param name="colors">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray G_RegionGrowingNC2(MWArray points, MWArray normals, MWArray colors)
    {
      return mcr.EvaluateFunction("G_RegionGrowingNC2", points, normals, colors);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the G_RegionGrowingNC2
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="points">Input argument #1</param>
    /// <param name="normals">Input argument #2</param>
    /// <param name="colors">Input argument #3</param>
    /// <param name="ThresValN">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray G_RegionGrowingNC2(MWArray points, MWArray normals, MWArray colors, 
                                MWArray ThresValN)
    {
      return mcr.EvaluateFunction("G_RegionGrowingNC2", points, normals, colors, ThresValN);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the G_RegionGrowingNC2
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="points">Input argument #1</param>
    /// <param name="normals">Input argument #2</param>
    /// <param name="colors">Input argument #3</param>
    /// <param name="ThresValN">Input argument #4</param>
    /// <param name="ThresValC">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray G_RegionGrowingNC2(MWArray points, MWArray normals, MWArray colors, 
                                MWArray ThresValN, MWArray ThresValC)
    {
      return mcr.EvaluateFunction("G_RegionGrowingNC2", points, normals, colors, ThresValN, ThresValC);
    }


    /// <summary>
    /// Provides a single output, 6-input MWArrayinterface to the G_RegionGrowingNC2
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="points">Input argument #1</param>
    /// <param name="normals">Input argument #2</param>
    /// <param name="colors">Input argument #3</param>
    /// <param name="ThresValN">Input argument #4</param>
    /// <param name="ThresValC">Input argument #5</param>
    /// <param name="MaxDist">Input argument #6</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray G_RegionGrowingNC2(MWArray points, MWArray normals, MWArray colors, 
                                MWArray ThresValN, MWArray ThresValC, MWArray MaxDist)
    {
      return mcr.EvaluateFunction("G_RegionGrowingNC2", points, normals, colors, ThresValN, ThresValC, MaxDist);
    }


    /// <summary>
    /// Provides a single output, 7-input MWArrayinterface to the G_RegionGrowingNC2
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="points">Input argument #1</param>
    /// <param name="normals">Input argument #2</param>
    /// <param name="colors">Input argument #3</param>
    /// <param name="ThresValN">Input argument #4</param>
    /// <param name="ThresValC">Input argument #5</param>
    /// <param name="MaxDist">Input argument #6</param>
    /// <param name="Minsize">Input argument #7</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray G_RegionGrowingNC2(MWArray points, MWArray normals, MWArray colors, 
                                MWArray ThresValN, MWArray ThresValC, MWArray MaxDist, 
                                MWArray Minsize)
    {
      return mcr.EvaluateFunction("G_RegionGrowingNC2", points, normals, colors, ThresValN, ThresValC, MaxDist, Minsize);
    }


    /// <summary>
    /// Provides a single output, 8-input MWArrayinterface to the G_RegionGrowingNC2
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="points">Input argument #1</param>
    /// <param name="normals">Input argument #2</param>
    /// <param name="colors">Input argument #3</param>
    /// <param name="ThresValN">Input argument #4</param>
    /// <param name="ThresValC">Input argument #5</param>
    /// <param name="MaxDist">Input argument #6</param>
    /// <param name="Minsize">Input argument #7</param>
    /// <param name="Offset">Input argument #8</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray G_RegionGrowingNC2(MWArray points, MWArray normals, MWArray colors, 
                                MWArray ThresValN, MWArray ThresValC, MWArray MaxDist, 
                                MWArray Minsize, MWArray Offset)
    {
      return mcr.EvaluateFunction("G_RegionGrowingNC2", points, normals, colors, ThresValN, ThresValC, MaxDist, Minsize, Offset);
    }


    /// <summary>
    /// Provides a single output, 9-input MWArrayinterface to the G_RegionGrowingNC2
    /// MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="points">Input argument #1</param>
    /// <param name="normals">Input argument #2</param>
    /// <param name="colors">Input argument #3</param>
    /// <param name="ThresValN">Input argument #4</param>
    /// <param name="ThresValC">Input argument #5</param>
    /// <param name="MaxDist">Input argument #6</param>
    /// <param name="Minsize">Input argument #7</param>
    /// <param name="Offset">Input argument #8</param>
    /// <param name="Tilesize">Input argument #9</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray G_RegionGrowingNC2(MWArray points, MWArray normals, MWArray colors, 
                                MWArray ThresValN, MWArray ThresValC, MWArray MaxDist, 
                                MWArray Minsize, MWArray Offset, MWArray Tilesize)
    {
      return mcr.EvaluateFunction("G_RegionGrowingNC2", points, normals, colors, ThresValN, ThresValC, MaxDist, Minsize, Offset, Tilesize);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the G_RegionGrowingNC2 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] G_RegionGrowingNC2(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_RegionGrowingNC2", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the G_RegionGrowingNC2 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="points">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] G_RegionGrowingNC2(int numArgsOut, MWArray points)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_RegionGrowingNC2", points);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the G_RegionGrowingNC2 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="points">Input argument #1</param>
    /// <param name="normals">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] G_RegionGrowingNC2(int numArgsOut, MWArray points, MWArray normals)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_RegionGrowingNC2", points, normals);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the G_RegionGrowingNC2 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="points">Input argument #1</param>
    /// <param name="normals">Input argument #2</param>
    /// <param name="colors">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] G_RegionGrowingNC2(int numArgsOut, MWArray points, MWArray normals, 
                                  MWArray colors)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_RegionGrowingNC2", points, normals, colors);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the G_RegionGrowingNC2 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="points">Input argument #1</param>
    /// <param name="normals">Input argument #2</param>
    /// <param name="colors">Input argument #3</param>
    /// <param name="ThresValN">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] G_RegionGrowingNC2(int numArgsOut, MWArray points, MWArray normals, 
                                  MWArray colors, MWArray ThresValN)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_RegionGrowingNC2", points, normals, colors, ThresValN);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the G_RegionGrowingNC2 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="points">Input argument #1</param>
    /// <param name="normals">Input argument #2</param>
    /// <param name="colors">Input argument #3</param>
    /// <param name="ThresValN">Input argument #4</param>
    /// <param name="ThresValC">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] G_RegionGrowingNC2(int numArgsOut, MWArray points, MWArray normals, 
                                  MWArray colors, MWArray ThresValN, MWArray ThresValC)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_RegionGrowingNC2", points, normals, colors, ThresValN, ThresValC);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the G_RegionGrowingNC2 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="points">Input argument #1</param>
    /// <param name="normals">Input argument #2</param>
    /// <param name="colors">Input argument #3</param>
    /// <param name="ThresValN">Input argument #4</param>
    /// <param name="ThresValC">Input argument #5</param>
    /// <param name="MaxDist">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] G_RegionGrowingNC2(int numArgsOut, MWArray points, MWArray normals, 
                                  MWArray colors, MWArray ThresValN, MWArray ThresValC, 
                                  MWArray MaxDist)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_RegionGrowingNC2", points, normals, colors, ThresValN, ThresValC, MaxDist);
    }


    /// <summary>
    /// Provides the standard 7-input MWArray interface to the G_RegionGrowingNC2 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="points">Input argument #1</param>
    /// <param name="normals">Input argument #2</param>
    /// <param name="colors">Input argument #3</param>
    /// <param name="ThresValN">Input argument #4</param>
    /// <param name="ThresValC">Input argument #5</param>
    /// <param name="MaxDist">Input argument #6</param>
    /// <param name="Minsize">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] G_RegionGrowingNC2(int numArgsOut, MWArray points, MWArray normals, 
                                  MWArray colors, MWArray ThresValN, MWArray ThresValC, 
                                  MWArray MaxDist, MWArray Minsize)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_RegionGrowingNC2", points, normals, colors, ThresValN, ThresValC, MaxDist, Minsize);
    }


    /// <summary>
    /// Provides the standard 8-input MWArray interface to the G_RegionGrowingNC2 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="points">Input argument #1</param>
    /// <param name="normals">Input argument #2</param>
    /// <param name="colors">Input argument #3</param>
    /// <param name="ThresValN">Input argument #4</param>
    /// <param name="ThresValC">Input argument #5</param>
    /// <param name="MaxDist">Input argument #6</param>
    /// <param name="Minsize">Input argument #7</param>
    /// <param name="Offset">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] G_RegionGrowingNC2(int numArgsOut, MWArray points, MWArray normals, 
                                  MWArray colors, MWArray ThresValN, MWArray ThresValC, 
                                  MWArray MaxDist, MWArray Minsize, MWArray Offset)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_RegionGrowingNC2", points, normals, colors, ThresValN, ThresValC, MaxDist, Minsize, Offset);
    }


    /// <summary>
    /// Provides the standard 9-input MWArray interface to the G_RegionGrowingNC2 MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="points">Input argument #1</param>
    /// <param name="normals">Input argument #2</param>
    /// <param name="colors">Input argument #3</param>
    /// <param name="ThresValN">Input argument #4</param>
    /// <param name="ThresValC">Input argument #5</param>
    /// <param name="MaxDist">Input argument #6</param>
    /// <param name="Minsize">Input argument #7</param>
    /// <param name="Offset">Input argument #8</param>
    /// <param name="Tilesize">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] G_RegionGrowingNC2(int numArgsOut, MWArray points, MWArray normals, 
                                  MWArray colors, MWArray ThresValN, MWArray ThresValC, 
                                  MWArray MaxDist, MWArray Minsize, MWArray Offset, 
                                  MWArray Tilesize)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_RegionGrowingNC2", points, normals, colors, ThresValN, ThresValC, MaxDist, Minsize, Offset, Tilesize);
    }


    /// <summary>
    /// Provides an interface for the G_RegionGrowingNC2 function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns point
    /// groups of similar properties. The main goal is point cloud segmentation
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void G_RegionGrowingNC2(int numArgsOut, ref MWArray[] argsOut, MWArray[] 
                         argsIn)
    {
      mcr.EvaluateFunction("G_RegionGrowingNC2", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the G_Resolution_PCD MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns teh average
    /// point spacing based on a number of samples
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray G_Resolution_PCD()
    {
      return mcr.EvaluateFunction("G_Resolution_PCD", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the G_Resolution_PCD MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns teh average
    /// point spacing based on a number of samples
    /// </remarks>
    /// <param name="points">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray G_Resolution_PCD(MWArray points)
    {
      return mcr.EvaluateFunction("G_Resolution_PCD", points);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the G_Resolution_PCD MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns teh average
    /// point spacing based on a number of samples
    /// </remarks>
    /// <param name="points">Input argument #1</param>
    /// <param name="samples">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray G_Resolution_PCD(MWArray points, MWArray samples)
    {
      return mcr.EvaluateFunction("G_Resolution_PCD", points, samples);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the G_Resolution_PCD MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns teh average
    /// point spacing based on a number of samples
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] G_Resolution_PCD(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_Resolution_PCD", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the G_Resolution_PCD MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns teh average
    /// point spacing based on a number of samples
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="points">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] G_Resolution_PCD(int numArgsOut, MWArray points)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_Resolution_PCD", points);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the G_Resolution_PCD MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns teh average
    /// point spacing based on a number of samples
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="points">Input argument #1</param>
    /// <param name="samples">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] G_Resolution_PCD(int numArgsOut, MWArray points, MWArray samples)
    {
      return mcr.EvaluateFunction(numArgsOut, "G_Resolution_PCD", points, samples);
    }


    /// <summary>
    /// Provides an interface for the G_Resolution_PCD function in which the input and
    /// output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// Explenation
    /// this function takes as input any point cloud and returns teh average
    /// point spacing based on a number of samples
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void G_Resolution_PCD(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("G_Resolution_PCD", numArgsOut, ref argsOut, argsIn);
    }



    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private static Exception ex_= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
