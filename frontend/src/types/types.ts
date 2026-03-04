import type { components, paths } from "@/types/openapi-types";

export type TodoItemType = components["schemas"]["TodoItem"];
export type PagedResult = components["schemas"]["PagedResultOfTodoItem"];

export type CreateTodoRequest = components["schemas"]["CreateTodoRequest"];
export type UpdateTodoRequest = components["schemas"]["UpdateTodoRequest"];

export type TodoQuery = paths["/todos"]["get"]["parameters"]["query"];

export type TodoPageParams = Pick<
	NonNullable<TodoQuery>,
	"PageNumber" | "PageSize"
>;
export type TodoQueryParams = Omit<
	NonNullable<TodoQuery>,
	"PageNumber" | "PageSize"
>;

export type SortBy = components["schemas"]["SortBy"];
export type SortDir = components["schemas"]["SortDir"];

export type UrgencyLevel = components["schemas"]["UrgencyLevel"];
