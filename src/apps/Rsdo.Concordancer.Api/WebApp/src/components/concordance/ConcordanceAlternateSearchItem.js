import { Link } from 'react-router-dom';
import useSearch from '../../hooks/use-search';
import styles from './ConcordanceAlternateSearchItem.module.scss';

const ConcordanceAlternateSearchItem = (props) => {
    const search = useSearch();
    const link = search.getAlternateSearchLink(props.search);
    return (
        <li className={styles.alternateSearchItem}><Link to={link}><span className={styles.title}>{props.title}</span><span className={styles.count}>{props.count}</span></Link></li>
    );
};

export default ConcordanceAlternateSearchItem;