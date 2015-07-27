reqestMesh>Node, Node{ _node, position, LOD, densityData }

requestArray: Queue<MeshRequest> []

requestArray[i]本身也有Count？

MeshRequest {
[int]LOD, 
[Vector3]pos,
[Node]node, 
[bool]isDone, 
[bool]hasDensities, 
[MeshData]meshData, 
[DensityData] densities
}

##marching cubes

generateTriangles(
	node
	[Vector3I]pos
	[List<Triangle>]triangleList
	[List<int>] submeshIDList
	[int[]] subMeshTriCount
	[DensityData] densities
	[Vector3[,,]] densityNormals
)
{
	###field
	size
	denses
	cubeIndex
	isolevel?

}

