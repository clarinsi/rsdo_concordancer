import { Link } from 'react-router-dom';
import { useTranslation } from 'react-i18next';

import useSearch from '../../hooks/use-search';
import styles from './ResultsPager.module.scss';

const ResultsPager = (props) => {
    const pageSize = 20;
    const offset = props.offset;
    const total = props.total;
    const totalPages = Math.ceil(total / pageSize);
    const currentPage = Math.floor(offset / pageSize) + 1;

    // Hooks
    const { t } = useTranslation();
    const search = useSearch();

    const renderPreviousPage = () => {
        const className = currentPage <= 1 ? 'disabled' : null;
        return renderPage(currentPage - 1, '<<', className);
    };

    const renderFirstPage = () => {
        const className = currentPage === 1 ? 'active' : null;
        return renderPage(1, '1', className);
    };

    const renderCurrentPage = () => {
        return renderPage(currentPage, currentPage, 'active');
    };

    const renderLastPage = () => {
        const className = currentPage === totalPages ? 'active' : null;
        return renderPage(totalPages, totalPages, className);
    };

    const renderNextPage = () => {
        const className = currentPage >= totalPages ? 'disabled' : null;
        return renderPage(currentPage + 1, '>>', className);
    };

    const renderPage = (page, title, className) => {
        const link = search.getPagerLink(page);
        return (
            <Link className={styles[className]} to={link}>{title}</Link>
        );
    };

    return (
        <div className={`row align-items-center ${styles.pager}`}>
            <div className='col'>{t('shared.searchRecords', { start: offset + 1, end: offset + pageSize, total: total })}</div>
            <div className='col'>
                <div className={`${styles.pages} float-end`}>
                    {renderPreviousPage()}
                    {currentPage > 1 && renderFirstPage()}
                    {renderCurrentPage()}
                    {currentPage < totalPages && renderLastPage()}
                    {renderNextPage()}
                </div>
            </div>
        </div>
    );
};


export default ResultsPager;