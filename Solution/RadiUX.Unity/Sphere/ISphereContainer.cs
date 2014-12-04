﻿using RadiUX.Model.Sphere;

namespace RadiUX.Unity.Sphere {

	/*================================================================================================*/
	public interface ISphereContainer {

		SphereContainerData Data { get; }
		ISphereLayout Layout { get; }
		ISphereContainer Container { get; }

	}

}
