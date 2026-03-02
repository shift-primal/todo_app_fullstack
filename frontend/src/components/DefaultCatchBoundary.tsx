import { useRouter, type ErrorComponentProps } from "@tanstack/react-router";

export function DefaultCatchBoundary({ error }: ErrorComponentProps) {
  const router = useRouter();
  return (
    <div className="flex min-h-screen items-center justify-center">
      <div className="text-center">
        <h2 className="mb-2 text-2xl font-bold text-red-600">
          Something went wrong
        </h2>
        <p className="mb-4 text-gray-600">{error.message}</p>
        <button
          onClick={() => router.invalidate()}
          className="rounded bg-blue-500 px-4 py-2 text-white hover:bg-blue-600"
        >
          Try again
        </button>
      </div>
    </div>
  );
}
