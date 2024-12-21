#pragma warning disable SYSLIB5001 // Suppress evaluation purposes warning for Tensor<T>

using System.Numerics.Tensors;

namespace MirajAI.Interfaces
{

    /// <summary>
    /// Defines the contract for activation functions used in neural networks.
    /// </summary>
    /// <typeparam name="T">The numerical data type of inputs and outputs, constrained to unmanaged types.</typeparam>

    public interface IActivationFunction<T> where T : unmanaged
    {

        /// <summary>
        /// Gets the unique name of the activation function (e.g., "ReLU", "Sigmoid").
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Applies the activation function to the input tensor.
        /// </summary>
        /// <param name="input">The input tensor.</param>
        /// <returns>The tensor after applying the activation function.</returns>
        Tensor<T> Compute(Tensor<T> input);

        /// <summary>
        /// Computes the gradient of the activation function for backpropagation.
        /// </summary>
        /// <param name="input">The input tensor (pre-activation).</param>
        /// <param name="outputGradient">The gradient of the loss with respect to the activation output.</param>
        /// <returns>The gradient of the loss with respect to the input.</returns>
        Tensor<T> Gradient(Tensor<T> input, Tensor<T> outputGradient);
    }
}
#pragma warning restore SYSLIB5001