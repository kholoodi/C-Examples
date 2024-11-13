namespace Volumes {
	class Sphere : FlatShapes.Circle {
	  new public double Area {
		  get { return 4 * Radius * Radius *3.14159; }
		}
	  public double Volume {
		    get { return 4 * 3.14159 * Radius * Radius *Radius /3 ; }
		  }
	}//end class 
}//end namespace
