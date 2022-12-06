import { Link } from 'react-router-dom';
import useSearch from '../../hooks/use-search';

import styles from './HistoryItem.module.scss';

const HistoryItem = (props) => {
    const search = useSearch();
    const source = props.source;

    return (
        <li className={styles.historyListItem}>
            <Link to={search.getSearchLink(source, props.query)}>{props.query}</Link>
        </li>
    );
};

export default HistoryItem;