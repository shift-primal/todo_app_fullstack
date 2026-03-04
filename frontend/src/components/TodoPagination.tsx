import {
	Pagination,
	PaginationContent,
	PaginationItem,
	PaginationNext,
	PaginationPrevious,
} from "@/components/ui/pagination";
import { TodoPageParams } from "@/types/types";
import { Dispatch, SetStateAction } from "react";

type Props = {
	page: TodoPageParams;
	setPage: Dispatch<SetStateAction<TodoPageParams>>;
	totalPages: number;
};

export const TodoPagination = ({ page, setPage, totalPages }: Props) => {
	const currentPage = page.PageNumber as number;

	return (
		<Pagination>
			<PaginationContent>
				<PaginationItem>
					<PaginationPrevious
						onClick={() =>
							setPage((p) => ({
								...p,
								PageNumber: currentPage - 1,
							}))
						}
						aria-disabled={currentPage === 1}
						className={
							currentPage === 1
								? "pointer-events-none opacity-50"
								: "cursor-pointer"
						}
					/>
				</PaginationItem>
				<PaginationItem>
					<span className="px-4 py-2 text-sm">
						Page {currentPage}
					</span>
				</PaginationItem>
				<PaginationItem>
					<PaginationNext
						onClick={() =>
							setPage((p) => ({
								...p,
								PageNumber: currentPage + 1,
							}))
						}
						aria-disabled={currentPage === totalPages}
						className={
							currentPage === totalPages
								? "pointer-events-none opacity-50"
								: "cursor-pointer"
						}
					/>
				</PaginationItem>
			</PaginationContent>
		</Pagination>
	);
};
