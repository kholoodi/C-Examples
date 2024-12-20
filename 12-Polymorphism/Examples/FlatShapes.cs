namespace FlatShapes {
	public class Circle {
		private double _radius;
		public double Radius {
		  get { return (_radius < 0) ? 0.00 : _radius;}
		  set { _radius = value;}
		}
	public double Diameter {
		get { return Radius * 2;}
    	}
	public double Circumference {
      		get { return Diameter * 3.14159;}
    	}
   	 public double Area {
		get { return Radius * Radius * 3.14159;}
    	}
    }//end class
} //end namespace
