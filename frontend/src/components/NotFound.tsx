import { Link } from "@tanstack/react-router";

export function NotFound() {
  return (
    <div className="flex min-h-screen items-center justify-center">
      <div className="text-center">
        <h2 className="mb-2 text-4xl font-bold text-gray-900">404</h2>
        <p className="mb-4 text-gray-600">Page not found</p>
        <Link
          to="/"
          className="rounded bg-blue-500 px-4 py-2 text-white hover:bg-blue-600"
        >
          Go home
        </Link>
      </div>
    </div>
  );
}
