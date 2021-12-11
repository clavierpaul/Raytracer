﻿namespace Raytracer.Rendering

open Raytracer.Rendering
open Vector

type Ray = { Origin: Point3; Direction: Vector3 }

module Ray =
    let at (t: float) ray = ray.Origin + ray.Direction * t
